using Microsoft.AspNetCore.Mvc;
namespace meals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController()
        {
        }
        [HttpGet]
        public void GetCategories()
        {

        }
    }
}

