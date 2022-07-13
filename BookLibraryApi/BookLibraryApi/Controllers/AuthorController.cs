using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Author;
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
        
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<AuthorModel>>> Get()
        {
            var authors = await authorService.GetAll();
            return Ok(mapper.Map<List<AuthorModel>>(authors));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AuthorModel>>> GetById(int id)
        {
            var authors = await authorService.GetAll();
            foreach (var author in authors)
            {
                if (author.Id == id)
                    return Ok(mapper.Map<AuthorModel>(author));
            }
            return NotFound($"Author with id {id} not found.");
        }
        [HttpPost]
        public async Task<ActionResult<AuthorModel>> Add([FromBody] AuthorPostModel authorPostModel)
        {
            var author = mapper.Map<Author>(authorPostModel);
            var authorAdded = await authorService.Add(author);

            return CreatedAtAction(nameof(GetById), new { authorAdded.Id }, authorAdded);
        }
        
        [HttpPut]
        public async Task<ActionResult<AuthorModel>> Update([FromBody] AuthorModel authorModel)
        {
            var item = mapper.Map<Author>(authorModel);
            await authorService.Update(item);
            return CreatedAtAction(nameof(GetById), new { item.Id }, item);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthorModel>> Delete(int id)
        {
            await authorService.DeleteById(id);
            return Ok($"Author with id {id} deleted");
        }
    }
}
