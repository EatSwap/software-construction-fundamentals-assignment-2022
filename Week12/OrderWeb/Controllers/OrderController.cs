namespace OrderWeb.Controllers;

using Base;
using Microsoft.AspNetCore.Mvc;
using Services;

[ApiController]
[Route("v1/api/[controller]")]
public class OrderController : ControllerBase {
	private static readonly OrderService _orderService = new();

	[HttpGet("test")]
	public HttpResponse<string> Test() {
		return HttpResponse<string>.Success("foo, bar");
	}
}