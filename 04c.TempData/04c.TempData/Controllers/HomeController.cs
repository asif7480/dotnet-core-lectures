using Microsoft.AspNetCore.Mvc;

namespace _04c.TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Val1 = "Value of view bag";     
            ViewData["Val2"] = "I am view data";
            TempData["Val3"] = "I am temp data";

            //List<string> subjects = new List<string> { "html", "css", "js" };
            //TempData["Val4"] = subjects;
            TempData["Val4"] = new List<string>()
            {
                "html", "css", "js"
            };
            TempData.Keep("Val3");
            return View();
        }

        public IActionResult About()
        {
            TempData.Keep("Val3");
            return View();
        }

        public IActionResult Contact()
        {
            TempData.Keep("Val3");
            return View();
        }
    }
}
