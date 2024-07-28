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
        public IActionResult Register()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                

                var user = new AppUser
                {
                    UserName = userRegisterViewModel.Email,
                    Email = userRegisterViewModel.Email,
                    FisrName = userRegisterViewModel.FirstName,
                    LastName = userRegisterViewModel.LastName,
                };

                var result = await userManager.CreateAsync(user, userRegisterViewModel.Password);
                if (result.Succeeded)
                {
                    if (user.Email == "hamidovaraqsana@gmail.com")
                    {
                        await userManager.AddToRoleAsync(user, "SuperAdmin");
                    }
                    else
                    {
                        await userManager.AddToRoleAsync(user, "User");
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(userRegisterViewModel);
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
