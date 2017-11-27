using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clothing.Repositories;

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

        [Route("/warehouse")]
        public IActionResult Clothes()
        {
            return View(clothRepository.ListOfClothes());
        }
    }
}
