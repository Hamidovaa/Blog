using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user=await userManager.FindByEmailAsync(userLoginViewModel.Email);
                if (user != null)
                {
                    var result=await signInManager.PasswordSignInAsync(user, userLoginViewModel.Password, userLoginViewModel.RememberMe, false);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new {Area="Admin"});   
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email or password wrong");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email or password wrong");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = " " });
        }
    }
}
