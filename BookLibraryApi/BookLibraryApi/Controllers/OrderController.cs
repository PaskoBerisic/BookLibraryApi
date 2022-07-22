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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderModel>>> Get()
        {
            var orders = await orderService.GetAll();
            return Ok(mapper.Map<List<OrderModel>>(orders));
        }
        [HttpGet("allWith")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetAllWith()
        {
            var orders = await orderService.GetAll();
            return Ok(mapper.Map<List<OrderModel>>(orders));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetById(int id)
        {
            var orders = await orderService.GetAll();
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
        public async Task<ActionResult<OrderModel>> Add([FromBody] OrderPostModel orderPostModel)
            {
            var order = mapper.Map<Order>(orderPostModel);
            var orderAdded = await orderService.Add(order);
            return CreatedAtAction(nameof(GetById), new { orderAdded.Id }, orderAdded);
        }

        [HttpPut]
        public async Task<ActionResult<OrderModel>> Update([FromBody] OrderPutModel orderPutModel)
        {
            var item = mapper.Map<Order>(orderPutModel);
            await orderService.Update(item);
            return CreatedAtAction(nameof(GetById), new { item.Id }, item);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderModel>> Delete(int id)
        {
            await orderService.DeleteById(id);
            return Ok($"Order with id {id} deleted");
        }
    
    }
}
