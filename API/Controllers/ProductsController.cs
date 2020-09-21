using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProduts()

        {
            return "this is will be a list of products";
        }

        [HttpGet("{id}")]
        public string GetProdut(int id)
        {
            return "single product";
        }
    }
}