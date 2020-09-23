using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain;
//using API.Services.ProductService;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product> {
            new Product(),
            new Product { Title = "Kilde blå"}
        };

        public IActionResult Get()
        {
            return Ok(products);
        }

    }
}