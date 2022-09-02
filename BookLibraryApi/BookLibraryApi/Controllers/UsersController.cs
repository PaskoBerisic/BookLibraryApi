using ApplicationCore.Authentication;
using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces.Auth;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.User;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IUserBasketService userBasketService;
        private readonly IOrderService orderService;
        private readonly IUserServiceJWT userServiceJwt;
        private readonly IMapper mapper;

        public UsersController(
            IUserService userService,
            IUserBasketService userBasketService,
            IOrderService orderService,
            IUserServiceJWT userServiceJwt,
            IMapper mapper)
        {
            this.userService = userService;
            this.userBasketService = userBasketService;
            this.orderService = orderService;
            this.userServiceJwt = userServiceJwt;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModelResponse>>> GetAllUsers()
        {
            var users = await userService.GetAllWithSpec();
            return Ok(mapper.Map<List<UserModelResponse>>(users));
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModelResponse>> GetUserById(int id)
        {
            var user = await userService.GetById(id);
            if (user is null)
            {
                return NotFound($"User with id {id} not found.");
            }
            return Ok(mapper.Map<UserModelResponse>(user));
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<UserModelResponse>> AddUser([FromBody] UserModelRequest userModel)
        {
            var user = mapper.Map<User>(userModel);

            var existingUser = await userService.GetByUsername(user.Username);
            if (existingUser is null)
            {
                var userAdded = await userService.Add(user);
                return CreatedAtAction(nameof(GetUserById), new { userAdded.Id }, userAdded);
            }
            return BadRequest($"Username '{user.Username}' is not avaiable!");
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpPut]
        public async Task<ActionResult<UserModelResponse>> UpdateUser([FromBody] UserModelRequest userModel)
        {
            var item = mapper.Map<User>(userModel);

            await userService.Update(item);
            return CreatedAtAction(nameof(GetUserById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            await userService.DeleteById(id);
            return Ok($"User with id {id} deleted");
        }

        [AllowAnonymous]
        [HttpGet("UsernameValidation")]
        public async Task<ActionResult<IEnumerable<UserModelResponse>>> GetUserByUsername(string username)
        {
            var user = await userService.GetByUsername(username);
            if (user is not null)
            {
                return Ok(mapper.Map<UserModelResponse>(user));
            }
            return NotFound($"User with username '{username}' not found.");
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<ActionResult<AuthenticateRequestJWT>> Authenticate([FromBody] AuthenticateRequestJWT authenticateRequest)
        {
            var response = await userServiceJwt.Authenticate(authenticateRequest);

            return Ok(response);
        }
    }
}

