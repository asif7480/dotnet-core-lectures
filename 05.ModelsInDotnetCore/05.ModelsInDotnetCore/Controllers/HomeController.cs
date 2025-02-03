using _05.ModelsInDotnetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05.ModelsInDotnetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<EmployeeModel>
            {
                new EmployeeModel{ empId= 1001, empName= "abc", dept= "hr", salary= 50000 },
                new EmployeeModel{ empId= 1002, empName= "xyz", dept= "finance", salary= 45000 }
            };

            ViewData["employees"] = employees;

            return View();
        }
    }
}
