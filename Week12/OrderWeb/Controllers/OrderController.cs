namespace OrderWeb.Controllers;

using Base;
using Microsoft.AspNetCore.Mvc;
using OrderManageCLI.models;
using Services;

[ApiController]
[Route("v1/api/[controller]")]
public class OrderController : ControllerBase {
	private static readonly OrderService _orderService = new();

	[HttpGet("test")]
	public HttpResponse<string> Test() {
		return HttpResponse<string>.Success("foo, bar");
	}

	[HttpPost("")]
	public HttpResponse<object> CreateOrder(Order order) {
		try {
			_orderService.createOrder(order);
			return HttpResponse<object>.Success();
		} catch (Exception e) {
			return HttpResponse<object>.ErrorWithMessage(e.Message);
		}
	}

	[HttpGet("{id}")]
	public HttpResponse<Order> GetOrder(string id) {
		try {
			if (!int.TryParse(id, out var orderId)) {
				throw new Exception("Invalid order id");
			}
			var order = _orderService.getOrder(orderId);
			return HttpResponse<Order>.Success(order);
		} catch (Exception e) {
			return HttpResponse<Order>.ErrorWithMessage(e.Message);
		}
	}

	[HttpGet("all")]
	public HttpResponse<List<Order>> GetAllOrders() {
		try {
			var orders = _orderService.getAllOrders();
			return HttpResponse<List<Order>>.Success(orders);
		} catch (Exception e) {
			return HttpResponse<List<Order>>.ErrorWithMessage(e.Message);
		}
	}

	[HttpPatch("{id}")]
	public HttpResponse<object> UpdateOrder(string id, Order order) {
		try {
			if (!int.TryParse(id, out var orderId)) {
				throw new Exception("Invalid order id");
			}
			_orderService.updateOrder(orderId, order);
			return HttpResponse<object>.Success(null);
		}
		catch (Exception e) {
			return HttpResponse<object>.ErrorWithMessage(e.Message);
		}
	}
	
	[HttpPatch("")]
	public HttpResponse<object> UpdateOrder(Order order) {
		try {
			_orderService.updateOrder(order);
			return HttpResponse<object>.Success(null);
		} catch (Exception e) {
			return HttpResponse<object>.ErrorWithMessage(e.Message);
		}
	}
	
	[HttpDelete("{id}")]
	public HttpResponse<object> DeleteOrder(string id) {
		try {
			if (!int.TryParse(id, out var orderId)) {
				throw new Exception("Invalid order id");
			}
			_orderService.deleteOrder(orderId);
			return HttpResponse<object>.Success(null);
		} catch (Exception e) {
			return HttpResponse<object>.ErrorWithMessage(e.Message);
		}
	}
}