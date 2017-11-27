using Clothing.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clothing.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        ClothRepository clothRepository;

        public HomeController(ClothRepository clothRepository)
        {
            this.clothRepository = clothRepository;
        }

        [HttpGet]
        [Route("/warehouse")]
        public IActionResult Clothes()
        {
            return View(clothRepository.ListOfClothes());
        }

        [HttpGet]
        [Route("/warehouse/summary")]
        public IActionResult Summary()
        {
            return View();
        }

        [HttpPost]
        [Route("/warehouse/summary")]
        public IActionResult GetItem([FromQuery] string item, [FromQuery] string size, [FromQuery] int amount)
        {
            clothRepository.AddClothes(item, amount, size);
            return RedirectToAction("Summary");
        }
    }
}
