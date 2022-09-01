using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Author;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;
        private readonly IMapper mapper;
        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            this.authorService = authorService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorModel>>> GetAllAuthors()
        {
            var authors = await authorService.GetAllWithSpec();
            return Ok(mapper.Map<List<AuthorModel>>(authors));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AuthorModel>>> GetById(int id)
        {
            var author = await authorService.GetById(id);
            if(author is not null)
            {
                return Ok(mapper.Map<AuthorModel>(author));
            }
            return NotFound($"Author with id {id} not found.");
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPost]
        public async Task<ActionResult<AuthorModel>> Add([FromBody] AuthorPostModel authorPostModel)
        {
            var author = mapper.Map<Author>(authorPostModel);
            var authorAdded = await authorService.Add(author);

            return CreatedAtAction(nameof(GetById), new { authorAdded.Id }, authorAdded);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpPut]
        public async Task<ActionResult<AuthorModel>> Update([FromBody] AuthorPutModel authorPutModel)
        {
            var item = mapper.Map<Author>(authorPutModel);
            await authorService.Update(item);
            return CreatedAtAction(nameof(GetById), new { item.Id }, item);
        }
        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthorModel>> Delete(int id)
        {
            await authorService.DeleteById(id);
            return Ok($"Author with id {id} deleted");
        }
    }
}
