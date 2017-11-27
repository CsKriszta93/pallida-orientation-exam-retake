using Clothing.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothing.Controllers
{
    [Route("")]
    public class RestController : Controller
    {
        ClothRepository clothRepository;

        public RestController(ClothRepository clothRepository)
        {
            this.clothRepository = clothRepository;
        }

        [HttpGet]
        [Route("/warehouse/query/{price}/{type}")]
        public IActionResult JsonPrice([FromQuery] double price, [FromQuery] string type)
        {
            var list = clothRepository.ListOfClothes();
            if (price < 50 || type.Equals("lower"))
            {
                return Json(new { result = "ok", clothes = list });
            }             
        }
    }
}
