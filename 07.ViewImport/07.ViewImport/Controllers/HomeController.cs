using _07.ViewImport.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07.ViewImport.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee> 
            {
                new Employee { empId= 1001, empName= "abc", email= "abc@gmail.com", salary= 40000 },
                new Employee { empId= 1001, empName= "abc", email= "abc@gmail.com", salary= 60000 }
            };
            return View(employees);
        }

        public IActionResult About()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { empId= 1001, empName= "abc", email= "abc@gmail.com", salary= 40000 },
                new Employee { empId= 1001, empName= "abc", email= "abc@gmail.com", salary= 60000 }
            };
            return View(employees);
        }

        public IActionResult Contact()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { empId= 1001, empName= "abc", email= "abc@gmail.com", salary= 40000 },
                new Employee { empId= 1001, empName= "abc", email= "abc@gmail.com", salary= 60000 }
            };
            return View(employees);
        }
    }
}
