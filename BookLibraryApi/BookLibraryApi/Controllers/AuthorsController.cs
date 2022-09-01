using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    [ApiController]
    public class AuthorsController : Controller
    {
        private readonly IAuthorService authorService;
        private readonly IMapper mapper;
        public AuthorsController(IAuthorService authorService, IMapper mapper)
        {
            this.authorService = authorService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorModelResponse>>> GetAllAuthors()
        {
            var authors = await authorService.GetAllWithSpec();

            return Ok(mapper.Map<List<AuthorModelResponse>>(authors));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorModelResponse>> GetAuthorById(int id)
        {
            var author = await authorService.GetById(id);

            if (author is null)
            {
                return NotFound($"Author with id {id} not found.");
            }
            return Ok(mapper.Map<AuthorModelResponse>(author));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPost]
        public async Task<ActionResult<AuthorModelResponse>> AddAuthor([FromBody] AuthorModelRequest authorModel)
        {
            var author = mapper.Map<Author>(authorModel);

            var authorAdded = await authorService.Add(author, authorModel.BookIds);
            return CreatedAtAction(nameof(GetAuthorById), new { authorAdded.Id }, authorAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut]
        public async Task<ActionResult<AuthorModelResponse>> UpdateAuthor([FromBody] AuthorModelRequest authorModel)
        {
            var item = mapper.Map<Author>(authorModel);

            await authorService.Update(item, authorModel.BookIds);
            return CreatedAtAction(nameof(GetAuthorById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthorModelRequest>> DeleteAuthor(int id)
        {
            await authorService.DeleteById(id);
            return Ok($"Author with id {id} deleted");
        }
    }
}
