using Microsoft.AspNetCore.Mvc;
using Projekt.Data;

namespace Projekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ApiDbContext _context;

        public ProductController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {

            var products = _context.Products.ToList().Where(x=>x.IsVisibility == true);

            return null;
        }

    }
}
