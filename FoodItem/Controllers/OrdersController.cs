using FoodItem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FoodOrdering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly List<Order> _orders = new List<Order>();

        [HttpPost]
        public ActionResult<decimal> CalculateTotalPrice(Order order)
        {
            decimal totalPrice = order.Items.Sum(item => item.Price * item.Quantity);
            return totalPrice;
        }

        [HttpPost("pay")]
        public ActionResult<string> ProcessPayment(Order order)
        {
            // Process payment logic here
            return "Payment processed successfully";
        }
    }
}
