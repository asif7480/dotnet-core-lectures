using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoleBaseAuthAndCrud.Models;
using RoleBaseAuthAndCrud.ViewModels;

namespace RoleBaseAuthAndCrud.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager) 
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid) return View(model);

            var user = new User { UserName = model.UserName, Email = model.Email, Gender = model.Gender, Address = model.Address };

            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded) 
            {
                await userManager.AddToRoleAsync(user, "User");
                return RedirectToAction("Login");
            }
            return View(model);
        }

        public IActionResult Login() => View();
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid login attempt");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}

