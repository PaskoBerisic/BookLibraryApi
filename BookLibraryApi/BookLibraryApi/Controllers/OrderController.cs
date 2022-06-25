using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using AutoMapper;
using BookLibraryWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IBookLibraryService bookLibraryService;
        private readonly IMapper mapper;
        public OrderController(IBookLibraryService bookLibraryService, IMapper mapper)
        {
            this.bookLibraryService = bookLibraryService;
            this.mapper = mapper;
        }

        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> Get()
        {
            var orders = await bookLibraryService.GetAllOrders();
            return Ok(mapper.Map<List<OrderModel>>(orders));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<OrderModel>>> GetById(int id)
        {
            var order = await bookLibraryService.GetOrderById(id);
            if (order is null)
            {
                return NotFound($"Order with id {id} not found.");
            }
            var orderModel = mapper.Map<OrderModel>(order);
            return Ok(orderModel);
        }

        [HttpPost]
        public async Task<ActionResult<OrderModel>> Add([FromBody] OrderModel orderModel)
        {
            var order = mapper.Map<Order>(orderModel);
            var orderAdded = await bookLibraryService.AddOrder(order);

            return CreatedAtAction(nameof(GetById), new { orderAdded.Id }, orderAdded);
        }

        [HttpPut]
        public async Task<ActionResult<OrderModel>> Update([FromBody] Order order)
        {
            await bookLibraryService.UpdateOrder(order);
            return CreatedAtAction(nameof(GetById), new { order.Id }, order);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderModel>> Delete(int id)
        {
            await bookLibraryService.DeleteOrderById(id);
            return Ok($"Order with id {id} deleted");
        }
    
    }
}
