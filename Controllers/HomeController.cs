using FutureValue.Models;
using Microsoft.AspNetCore.Mvc;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModels model)
        {
            if (ModelState.IsValid) 
            {
                ViewBag.Fv = model.CalculateFutureValue();
            }
            else  
            { 
                ViewBag.Fv = 0; 
            }

            return View(model);
        }
    }
}
