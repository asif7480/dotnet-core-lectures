using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace roleApp.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
