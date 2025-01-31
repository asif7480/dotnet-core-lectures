using Microsoft.AspNetCore.Mvc;

namespace _04a.ViewBag.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.Username = "abc";
			ViewBag.Age = 24;
			ViewBag.canCode = true;
			List<string>courses = new List<string> { "Php", "Python", "Java", "Nodejs" };
			ViewBag.courses = courses;
			return View();
		}

		public IActionResult SecondPage()
		{
			return View();
		}

		public IActionResult ThirdPage()
		{
			return View();
		}
	}
}
