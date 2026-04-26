using Microsoft.AspNetCore.Mvc;
using SportsonView.API.Core.Interfaces;

namespace SportsonView.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet("{orderNo}")]

        public async Task<IActionResult> GetOrdersAsync(string orderNo)
        {
            try
            {
                _logger.LogInformation("Received request to get order with order number: {OrderNo}", orderNo);
                var order = await _orderService.GetOrdersAsync(orderNo);
                return Ok(order);
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving order with order number: {OrderNo}", orderNo);
                return StatusCode(500, "Något gick fel");
            }
        }
    }
}