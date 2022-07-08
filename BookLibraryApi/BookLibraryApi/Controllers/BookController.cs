using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
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
            var books = await bookService.GetAllBooksWith();
            return Ok(mapper.Map<List<BookModel>>(books));
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetBooksWithAuthorsSpec()
        {
            var books = await bookService.GetAllBooksWith();
            return Ok(mapper.Map<List<BookModel>>(books));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetById(int id)
        {
            var books = await bookService.GetAllBooksWith();
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
            var bookAdded = await bookService.AddBook(book);
            return CreatedAtAction(nameof(GetById), new { bookAdded.Id }, bookAdded);
        }

        [HttpPut]
        public async Task<ActionResult<BookModel>> Update([FromBody] BookModelRequest bookModelRequest)
        {
            var item = mapper.Map<Book>(bookModelRequest);
            await bookService.UpdateBook(item);
            return CreatedAtAction(nameof(GetById), new { item.Id }, item);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BookModel>> Delete(int id)
        {
            await bookService.DeleteBookById(id);
            return Ok($"Book with id {id} deleted");
        }
    }

    
}
