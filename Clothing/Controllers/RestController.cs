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
    public class RestController : Controller
    {
        ClothRepository clothRepository;

        public RestController(ClothRepository clothRepository)
        {
            this.clothRepository = clothRepository;
        }

        [HttpGet]
        [Route("/warehouse/query")]
        public IActionResult JsonPrice([FromQuery] double price, [FromQuery] string type)
        {
            var list = clothRepository.ListOfClothes();
            var clothes = (from item in list
                           where item.unit_price < 50
                           select item).ToList();
            return Json(new { result = "ok", clothes = clothes });      
        }
    }
}
