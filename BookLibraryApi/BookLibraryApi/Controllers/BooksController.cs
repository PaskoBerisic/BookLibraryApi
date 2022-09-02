using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Book;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    public class BooksController : Controller
    {
        private readonly IBookService bookService;
        private readonly IMapper mapper;
        public BooksController(IBookService bookService, IMapper mapper)
        {
            this.bookService = bookService;
            this.mapper = mapper;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookModelResponse>>> GetAllBooks()
        {
            var books = await bookService.GetAllWithSpec();

            return Ok(mapper.Map<List<BookModelResponse>>(books));
        }

        [AllowAnonymous]
        [HttpGet("ByYearDesc")]
        public async Task<ActionResult<IEnumerable<BookModelResponse>>> GetBooksByYearDesc()
        {
            var specification = new BooksByYearSpecification();
            var books = await bookService.FindWithSpecification(specification);

            return Ok(mapper.Map<List<BookModelResponse>>(books));
        }

        [AllowAnonymous]
        [HttpGet("ByRentalNumber")]
        public async Task<ActionResult<IEnumerable<BookModelResponse>>> GetBooksByRentalNumber()
        {
            var specification = new BooksByRentalNumberSpecification();
            var books = await bookService.FindWithSpecification(specification);

            return Ok(mapper.Map<List<BookModelResponse>>(books));
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult<BookModelResponse>> GetBookById(int id)
        {
            var book = await bookService.GetById(id);
            if (book is null)
            {
                return NotFound($"Book with id {id} not found.");
            }
            return Ok(mapper.Map<BookModelResponse>(book));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPost]
        public async Task<ActionResult<BookModelResponse>> AddBook([FromBody] BookModelRequest bookModel)
        {
            var book = mapper.Map<Book>(bookModel);

            var bookAdded = await bookService.Add(book, bookModel.AuthorIds, bookModel.GenreIds);
            return CreatedAtAction(nameof(GetBookById), new { bookAdded.Id }, bookAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut]
        public async Task<ActionResult<BookModelResponse>> Update([FromBody] BookModelRequest bookModel)
        {
            var item = mapper.Map<Book>(bookModel);

            await bookService.Update(item, bookModel.AuthorIds, bookModel.GenreIds);
            return CreatedAtAction(nameof(GetBookById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<BookModelRequest>> Delete(int id)
        {
            await bookService.DeleteById(id);
            return Ok($"Book with id {id} deleted");
        }
    }
}
