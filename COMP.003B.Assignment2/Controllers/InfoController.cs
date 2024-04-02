using Microsoft.AspNetCore.Mvc;

namespace Comp._003B.Assignment2.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Hobbies() 
        {
            return View();
        }
    }
}
