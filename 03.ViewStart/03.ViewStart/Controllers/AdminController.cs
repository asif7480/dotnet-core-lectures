using Microsoft.AspNetCore.Mvc;

namespace _03.ViewStart.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult AllUsers()
		{
			return View();
		}
	}
}
