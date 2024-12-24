using Microsoft.AspNetCore.Mvc;
namespace APIConcepts.Controllers
{
    //Attribute Routing
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Route: api/products
        [HttpGet]
        public IActionResult GetAll()
        {
            // Return all products
            return Ok(new List<string> { "Product1", "Product2" });
        }

        // Route: api/products/{id}
        [HttpGet("{id:int=1}", Name = "GetProductById")]
        public IActionResult GetById(int id)
        {
            // Route: api/products/{id}
            return Ok($"Product{id}");
        }

        [HttpGet]
        [Route("category/{category}")]
        public IActionResult GetByCategory(string category)
        {
            // Route: api/products/category/{category}
            return Ok($"Category: {category}");
        }


        // Route: api/products
        [HttpPost]
        public IActionResult Create([FromBody] string product)
        {
            // Create a new product
            return CreatedAtAction(nameof(GetById), new { id = 3 }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] string product)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
