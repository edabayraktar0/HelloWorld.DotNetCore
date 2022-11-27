using Helloworld.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Helloworld.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var obj = new AppMessage()
            {
                Message = "Hello World"
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            ViewBag.Message = "Message has been changed.";
            return View(obj);
        }
    }
}
