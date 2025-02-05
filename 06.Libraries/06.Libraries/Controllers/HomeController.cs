using Microsoft.AspNetCore.Mvc;

namespace _06.Libraries.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
