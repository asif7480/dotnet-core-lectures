using Microsoft.AspNetCore.Mvc;

namespace _04b.ViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["username"] = "abc";
            ViewData["age"] = 22;
            ViewData["canCode"] = true;
            List<string> months = new List<string> { "Jan", "Feb", "Mar" };
            ViewData["months"] = months;
            return View();
        }
    }
}
