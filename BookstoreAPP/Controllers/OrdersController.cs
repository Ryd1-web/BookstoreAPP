using BookstoreAPP.Models;
using BookstoreAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreAPP.Controllers
{
    [Route("api/orders")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrdersController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpPost]
		public IActionResult PlaceOrder([FromBody] Order order)
		{
			var orderId = _orderService.PlaceOrder(order);
			return Ok(new { OrderId = orderId });
		}

		[HttpGet("{orderId}")]
		public IActionResult GetOrderById(int orderId)
		{
			var order = _orderService.GetOrderById(orderId);

			if (order == null)
			{
				return NotFound(); // Return a 404 Not Found if the order is not found.
			}

			return Ok(order);
		}
	}


}
