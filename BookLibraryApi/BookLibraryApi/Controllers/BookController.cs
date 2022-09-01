using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
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
    public class BookController : Controller
    {
        private readonly IBookService bookService;
        private readonly IMapper mapper;
        public BookController(IBookService bookService, IMapper mapper)
        {
            this.bookService = bookService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetAllBooks()
        {
            var books = await bookService.GetAllWithSpec();
            return Ok(mapper.Map<List<BookModel>>(books));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBooksWithAuthorsSpec()
        {
            var specification = new BooksWithIncludesSpecification();
            var books = await bookService.FindWithSpecificationPattern(specification);
            return Ok(mapper.Map<List<BookModel>>(books));
        }

        [AllowAnonymous]
        [HttpGet("ByYearDesc")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBooksByYearSpec()
        {
            var specification = new BooksByYearSpecification();
            var books = await bookService.FindWithSpecificationPattern(specification);
            return Ok(books);
        }
        [AllowAnonymous]
        [HttpGet("ByRentalNumber")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBooksByRentalNumberSpec()
        {
            var specification = new BooksByRentalNumberSpecification();
            var books = await bookService.FindWithSpecificationPattern(specification);
            return Ok(books);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetById(int id)
        {
            var book = await bookService.GetById(id);
            if (book is not null)
            {
                return Ok(mapper.Map<BookModel>(book));
            }
            return NotFound($"Book with id {id} not found.");
        }

        [HttpPost]
        public async Task<ActionResult<BookModel>> Add([FromBody] BookPostModel bookPostModel)
        {
            var book = mapper.Map<Book>(bookPostModel);
            var bookAdded = await bookService.Add(book);
            return CreatedAtAction(nameof(GetById), new { bookAdded.Id }, bookAdded);
        }

        [HttpPut]
        public async Task<ActionResult<BookModel>> Update([FromBody] BookPutModel bookPutModel)
        {
            var item = mapper.Map<Book>(bookPutModel);
            await bookService.Update(item);
            return CreatedAtAction(nameof(GetById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<BookModel>> Delete(int id)
        {
            await bookService.DeleteById(id);
            return Ok($"Book with id {id} deleted");
        }
    }


}
