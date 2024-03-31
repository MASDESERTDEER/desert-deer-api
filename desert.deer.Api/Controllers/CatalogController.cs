using Microsoft.AspNetCore.Mvc;
using desert.deer.Domain.Catalog;

namespace desert.deer.Api.Controllers {
    [ApiController]
    [Route("[controller]")]   
     public class CatalogController: ControllerBase {
        [HttpGet]
        public IActionResult GetItems(){
            var items = new List<Item>() {
                new Item("Shirt", "Ohio State Shirt", "Nike", 29.99m),
                new Item("Shorts", "Ohio State Shorts", "Nike", 44.99m)
            };
            return Ok(items);
        }
    }



}