using Microsoft.AspNetCore.Mvc;

namespace RoutesAndControllers.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
