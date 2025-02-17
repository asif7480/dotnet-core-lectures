using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using session12Crud.Models;

namespace session12Crud.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (ModelState.IsValid){
                await _context.Products.AddAsync(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
