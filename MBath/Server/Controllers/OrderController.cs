
using Microsoft.AspNetCore.Mvc;

namespace MBath.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderSrvc _orderService;

        public OrderController(IOrderSrvc orderService)
        {
            _orderService = orderService;
        }        


        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<OrderOverviewResponse>>>> GetOrders()
        {
            var result = await _orderService.GetOrderItemsAsync();
            return Ok(result);
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<ServiceResponse<OrderOverviewResponse>>> GetOrderDetails(int orderId)
        {
            var result = await _orderService.GetOrderDetails(orderId);
            return Ok(result);
        }
    }
}
