using _09.TagHelpersPart2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _09.TagHelpersPart2.Controllers
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
            return Content($"Name: {emp.EmpName}, Email: {emp.Email}, Department: {emp.Department}, Country: {emp.Country}, Gender: {emp.Gender}, Description: {emp.Description}");
            
        }

        public IActionResult AddEmployee()
        {
            return View();
        }
    }
}
