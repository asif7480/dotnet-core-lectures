using _10.TagHelperWithValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace _10.TagHelperWithValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            //return View();
            return Content($"Name is: {emp.Name} and Email is: {emp.Email}");
        }

        public IActionResult AddRecord()
        {
            return View();
        }
    }
}
