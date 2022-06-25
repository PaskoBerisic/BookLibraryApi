using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using AutoMapper;
using BookLibraryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookLibraryService bookLibraryService;
        private readonly IMapper mapper;
        public BookController(IBookLibraryService bookLibraryService, IMapper mapper)
        {
            this.bookLibraryService = bookLibraryService;
            this.mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<BookModel>>> Get()
        {
            var books = await bookLibraryService.GetAllBooks();
            return Ok(mapper.Map<List<BookModel>>(books));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<BookModel>>> GetById(int id)
        {
            var book = await bookLibraryService.GetBookById(id);
            if (book is null)
            {
                return NotFound($"Book with id {id} not found.");
            }
            var bookModel = mapper.Map<BookModel>(book);
            return Ok(bookModel);
        }

        [HttpPost]
        public async Task<ActionResult<BookModel>> Add([FromBody] BookModel bookModel)
        {
            var book = mapper.Map<Book>(bookModel);
            var bookAdded = await bookLibraryService.AddBook(book);

            return CreatedAtAction(nameof(GetById), new { bookAdded.Id }, bookAdded);
        }

        [HttpPut]
        public async Task<ActionResult<BookModel>> Update([FromBody] Book book)
        {
            await bookLibraryService.UpdateBook(book);
            return CreatedAtAction(nameof(GetById), new { book.Id }, book);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BookModel>> Delete(int id)
        {
            await bookLibraryService.DeleteBookById(id);
            return Ok($"Book with id {id} deleted");
        }
    }

    
}
