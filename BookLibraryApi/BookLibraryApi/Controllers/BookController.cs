using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using ApplicationCore.Specifications.Books;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Book;
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

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<BookModel>>> Get()
        {
            var books = await bookService.GetAll();
            return Ok(mapper.Map<List<BookModel>>(books));
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBooksWithAuthorsSpec()
        {
            var specification = new BookWithAuthorsSpecification();
            var books = await bookService.GetAllWithSpec(specification);
            return Ok(mapper.Map<List<BookModel>>(books));
        }

        [HttpGet("ByYearDesc")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBooksByYearSpec()
        {
            var specification = new BooksByYearSpecification();
            var books = await bookService.FindWithSpecificationPattern(specification);
            return Ok(books);
        }
        [HttpGet("ByRentalNumber")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBooksByRentalNumberSpec()
        {
            var specification = new BooksByRentalNumberSpecification();
            var books = await bookService.FindWithSpecificationPattern(specification);
            return Ok(books);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetById(int id)
        {
            var books = await bookService.GetAll();
            foreach (var book in books)
            {
                if (book.Id == id)
                    return Ok(mapper.Map<BookModel>(book));
            }
            return NotFound($"Book with id {id} not found.");
        }

        [HttpPost]
        public async Task<ActionResult<BookModel>> Add([FromBody] BookPostModel bookPostModel )
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<BookModel>> Delete(int id)
        {
            await bookService.DeleteById(id);
            return Ok($"Book with id {id} deleted");
        }
    }

    
}
