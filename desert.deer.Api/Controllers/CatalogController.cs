using Microsoft.AspNetCore.Mvc;
using desert.deer.Domain.Catalog;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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


        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id){
        var item = new Item("Shirt", "Ohio State Shirt", "Nike", 29.99m);
        item.Id = id;          
        return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item){
        return Created("catalog/42", item);
        }


        [HttpPost("{id}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating){
            var item = new Item("Shirt", "Ohio State Shirt", "Nike", 29.99m);
            item.Id  = id;
            item.AddRating(rating);
            return Ok(item);  
        }

        /* Test the post method using the folowing data in the body of the message: 

                {    
                            "stars": 5,
                            "userName": "John Smith",
                            "review": "Great!"
                        }
        */

       
        
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Item item){
            //return Ok(item);
            return NoContent();
        }
        /*   Test put using the following data in the body of the message: 
                    {
                        "id": 1,
                        "name": "Shirt",
                        "description": "Ohio State Shirt",
                        "brand": "Nike",
                        "price": 29.99,
                        "ratings": [
                            {
                                "stars": 5,
                                "userName": "John Smith",
                                "review": "Great!"
                            }
                        ]
                    }

        */

         [HttpDelete("{id:int}")]
        public IActionResult Delete(int id){
            //return Ok("Deleted!");
            return NoContent();
        }



        











    }



}