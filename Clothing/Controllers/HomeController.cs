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

        [HttpPost]
        [Route("/warehouse/summary")]
        public IActionResult GetItem(string item)
        {
            return View(clothRepository.GetSelectedItem(item));
        }
    }
}
