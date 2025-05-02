using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Retreat_Management_System.web.Models;
using System.Threading.Tasks;

namespace Retreat_Management_System.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: model.IsPersistent, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    // Redirect to the user dashboard instead of home page
                    return RedirectToAction("Index", "Dashboard");
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(model); // Return to the login view with validation errors
        }
    }
}