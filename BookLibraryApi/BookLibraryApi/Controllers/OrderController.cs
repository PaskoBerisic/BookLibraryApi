using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Order;
using Infrastructure.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowMyOrigin")]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IMapper mapper;
        public OrderController(IOrderService orderService, IMapper mapper)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderModel>>> Get()
        {
            var orders = await orderService.GetAllWith();
            return Ok(mapper.Map<List<OrderModel>>(orders));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("allWith")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetAllWith()
        {
            var orders = await orderService.GetAllWithSpec();
            return Ok(mapper.Map<List<OrderModel>>(orders));
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetById(int id)
        {
            var order = await orderService.GetById(id);
            if (order is not null)
            {
                return Ok(mapper.Map<OrderModel>(order));
            }
            return NotFound($"Order with id {id} not found.");
        }

        [AuthorizeJWT(Role.User, Role.Admin)]
        [HttpPost]
        public async Task<ActionResult<OrderModel>> Add([FromBody] OrderPostModel orderPostModel)
        {
            var order = mapper.Map<Order>(orderPostModel);
            var orderAdded = await orderService.Add(order);

            return CreatedAtAction(nameof(GetById), new { orderAdded.Id }, orderAdded);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpPut]
        public async Task<ActionResult<OrderModel>> Update([FromBody] OrderPutModel orderPutModel)
        {
            var item = mapper.Map<Order>(orderPutModel);
            await orderService.Update(item);
            return CreatedAtAction(nameof(GetById), new { item.Id }, item);
        }

        [AuthorizeJWT(Role.Admin)]
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderModel>> Delete(int id)
        {
            await orderService.DeleteById(id);
            return Ok($"Order with id {id} deleted");
        }

    }
}
