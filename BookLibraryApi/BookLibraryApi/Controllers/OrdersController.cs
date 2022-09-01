using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Order;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    public class OrdersController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IUserBasketService userBasketService;
        private readonly IMapper mapper;
        public OrdersController(IOrderService orderService,IUserBasketService userBasketService,IMapper mapper)
        {
            this.orderService = orderService;
            this.userBasketService = userBasketService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderModelResponse>>> GetAllOrders()
        {
            var orders = await orderService.GetAllWithSpec();
            return Ok(mapper.Map<List<OrderModelResponse>>(orders));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderModelResponse>> GetOrderById(int id)
        {
            var order = await orderService.GetById(id);

            if (order is null)
            {
                return NotFound($"Order with id {id} not found.");
            }
            return Ok(mapper.Map<OrderModelResponse>(order));
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpPost]
        public async Task<ActionResult<OrderModelResponse>> AddOrder([FromBody] OrderModelRequest orderModel)
        {
            var order = mapper.Map<Order>(orderModel);
            var bookIds = GetBookIds(orderModel);

            var orderAdded = await orderService.Add(order, bookIds);
            await userBasketService.ClearBasket(orderModel.UserBasketId);

            return CreatedAtAction(nameof(GetOrderById), new { orderAdded.Id }, orderAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut]
        public async Task<ActionResult<OrderModelResponse>> UpdateOrder([FromBody] OrderModelRequest orderModel)
        {
            var item = mapper.Map<Order>(orderModel);

            await orderService.Update(item, orderModel.BookIds);
            return CreatedAtAction(nameof(GetOrderById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderModelResponse>> DeleteOrder(int id)
        {
            await orderService.DeleteById(id);
            return Ok($"Order with id {id} deleted");
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpGet("UserOrders/{id}")]
        public async Task<ActionResult<IEnumerable<OrderModelResponse>>> GetUserOrders(int id)
        {
            var orders = await orderService.FindOrdersForUser(id);
            return Ok(mapper.Map<List<OrderModelResponse>>(orders));
        }

        [AuthorizeJWT(Role.Admin, Role.User)]
        [HttpGet("GetBookIds")]
        public ICollection<int> GetBookIds(OrderModelRequest orderModel)
        {
            ICollection<int> bookIds = new List<int>();
            foreach (var book in orderModel?.Books)
            {
                bookIds.Add(book.Id);
            }
            return bookIds;
        }
    }
}
