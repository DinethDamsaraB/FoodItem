using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FoodOrdering.Controllers
{
    public class FoodItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class FoodItemsController : ControllerBase
    {
        private readonly List<FoodItem> _availableItems = new List<FoodItem>
        {
            new FoodItem { Name = "Burger", Price = 200 },
            new FoodItem { Name = "Roll", Price = 50 },
            new FoodItem { Name = "Cake", Price = 400 },
            new FoodItem { Name = "Bun", Price = 30 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<FoodItem>> GetAvailableItems()
        {
            return Ok(_availableItems);
        }
    }
}
