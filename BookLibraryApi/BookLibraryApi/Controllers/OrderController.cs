using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Entity;
using AutoMapper;
using BookLibraryApi.Models;
using BookLibraryApi.Models.Order;
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

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> Get()
        {
            var orders = await orderService.GetAllOrdersWith();
            return Ok(mapper.Map<List<OrderModel>>(orders));
        }
        [HttpGet("allWith")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetAllWith()
        {
            var orders = await orderService.GetAllOrdersWith();
            return Ok(mapper.Map<List<OrderModel>>(orders));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetById(int id)
        {
            var orders = await orderService.GetAllOrdersWith();
            foreach (var order in orders)
            {
                if (order.Id == id)
                    return Ok(mapper.Map<OrderModel>(order));
            }
            return NotFound($"Order with id {id} not found.");
            //var order = await orderService.GetOrderById(id);
            //if (order is null)
            //{
            //    return NotFound($"Order with id {id} not found.");
            //}
            //var orderModel = mapper.Map<OrderModel>(order);
            //return Ok(orderModel);
        }

        [HttpPost]
        public async Task<ActionResult<OrderModel>> Add([FromBody] OrderModel orderModel)
        {
            var order = mapper.Map<Order>(orderModel);
            var orderAdded = await orderService.AddOrder(order);

            return CreatedAtAction(nameof(GetById), new { orderAdded.Id }, orderAdded);
        }

        [HttpPut]
        public async Task<ActionResult<OrderModel>> Update([FromBody] OrderModelRequest orderModelRequest)
        {
            var item = mapper.Map<Order>(orderModelRequest);
            await orderService.UpdateOrder(item);
            return CreatedAtAction(nameof(GetById), new { item.Id }, item);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderModel>> Delete(int id)
        {
            await orderService.DeleteOrderById(id);
            return Ok($"Order with id {id} deleted");
        }
    
    }
}
