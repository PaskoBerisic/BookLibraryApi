using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    public class UserBasketController : Controller
    {
        private readonly IUserBasketService userBasketService;
        private readonly IMapper mapper;
        public UserBasketController(IUserBasketService userBasketService, IMapper mapper) 
        {
            this.userBasketService = userBasketService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserBasketResponse>>> GetAllUserBaskets()
        {
            var userBaskets = await userBasketService.GetAllWithSpec();
            return Ok(mapper.Map<List<UserBasketResponse>>(userBaskets));
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpGet("{id}")]
        public async Task<ActionResult<UserBasketResponse>> GetUserBasketById(int id)
        {
            var userBasket = await userBasketService.GetById(id);
            if (userBasket is null)
            {
                return NotFound($"UserBasket with id {id} not found.");
            }
            return Ok(mapper.Map<UserBasketResponse>(userBasket));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<UserBasketResponse>> AddUserBasket([FromBody] UserBasketRequest userBasketModel)
        {
            var userBasket = mapper.Map<UserBasket>(userBasketModel);

            var userBasketAdded = await userBasketService.Add(userBasket, userBasketModel.BookIds);
            return CreatedAtAction(nameof(GetUserBasketById), new { userBasketAdded.Id }, userBasketAdded);
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpPut]
        public async Task<ActionResult<UserBasketResponse>> UpdateUserBasket([FromBody] UserBasketRequest userBasketModel)
        {
            var item = mapper.Map<UserBasket>(userBasketModel);

            await userBasketService.Update(item, userBasketModel.BookIds);
            return CreatedAtAction(nameof(GetUserBasketById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete]
        public async Task<ActionResult<UserBasketRequest>> DeleteUserBasket(int id)
        {
            await userBasketService.DeleteById(id);
            return Ok($"UserBasket with id {id} deleted");
        }

        [AllowAnonymous]
        [HttpPut("ClearBasket/{id}")]
        public async Task ClearBasket(int id)
        {
            await userBasketService.ClearBasket(id);
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpPost("AddBook")]
        public async Task AddBookToUserBasket([FromBody] AddBookRequest request)
        {
            await userBasketService.AddBookToUserBasket(request.bookId, request.userBasketId);
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpPost("DeleteBook")]
        public async Task DeleteBookFromUserBasket([FromBody] AddBookRequest request)
        {
            await userBasketService.DeleteBookFromUserBasket(request.bookId, request.userBasketId);
        }
    }
}
