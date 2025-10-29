using System.Diagnostics;
using FileUploading.Models;
using Microsoft.AspNetCore.Mvc;

namespace FileUploading.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment env;

        public HomeController(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            string fileName = Path.GetFileName(file.FileName);
            string filePath = Path.Combine(env.WebRootPath,"images",fileName);
            FileStream fs = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fs);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
