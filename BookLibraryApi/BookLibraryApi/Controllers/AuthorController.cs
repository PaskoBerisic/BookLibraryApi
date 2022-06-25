using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services;
using AutoMapper;
using BookLibraryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly IBookLibraryService bookLibraryService;
        private readonly IMapper mapper;
        public AuthorController(IBookLibraryService bookLibraryService, IMapper mapper)
        {
            this.bookLibraryService = bookLibraryService;
            this.mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<AuthorModel>>> Get()
        {
            var authors = await bookLibraryService.GetAllAuthors();
            return Ok(mapper.Map<List<AuthorModel>>(authors));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AuthorModel>>> GetById(int id)
        {
            var author = await bookLibraryService.GetAuthorById(id);
            if (author is null)
            {
                return NotFound($"Author with id {id} not found.");
            }
            var authorModel = mapper.Map<AuthorModel>(author);
            return Ok(authorModel);
        }

        [HttpPost]
        public async Task<ActionResult<AuthorModel>> Add([FromBody] AuthorModel authorModel)
        {
            var author = mapper.Map<Author>(authorModel);
            var authorAdded = await bookLibraryService.AddAuthor(author);

            return CreatedAtAction(nameof(GetById), new { authorAdded.Id }, authorAdded);
        }

        [HttpPut]
        public async Task<ActionResult<AuthorModel>> Update([FromBody] Author author)
        {
            await bookLibraryService.UpdateAuthor(author);
            return CreatedAtAction(nameof(GetById), new { author.Id }, author);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthorModel>> Delete(int id)
        {
            await bookLibraryService.DeleteAuthorById(id);
            return Ok($"Author with id {id} deleted");
        }
    
    }
}
