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
        [Route("/warehouse/query/")]
        public IActionResult JsonPrice([FromQuery] double price)
        {
            var list = clothRepository.ListOfClothes();
            if (price < 50)
            {
                return Json(new { result = "ok", clothes = list });
            }             
        }
    }
}
