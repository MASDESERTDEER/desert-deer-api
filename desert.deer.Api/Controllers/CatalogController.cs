using Microsoft.AspNetCore.Mvc;
using desert.deer.Domain.Catalog;

namespace desert.deer.Api.Controllers {
    [ApiController]
    [Route("[controller]")]   
     public class CatalogController: ControllerBase {
        [HttpGet]
        public IActionResult GetItems(){
            return Ok("Hello World!");
        }
    }



}