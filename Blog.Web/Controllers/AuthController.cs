using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment webHostEnvironment)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.webHostEnvironment = webHostEnvironment;
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
                string imagePath = "/images/profile/default.png"; // Varsayılan resim yolu
                Guid imageId = Guid.NewGuid();

                // Resim yükleme işlemi
                if (userRegisterViewModel.ProfileImage != null && userRegisterViewModel.ProfileImage.Length > 0)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images/profile");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + userRegisterViewModel.ProfileImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await userRegisterViewModel.ProfileImage.CopyToAsync(fileStream);
                    }
                    imagePath = "/images/profile/" + uniqueFileName;
                }

                // Resim nesnesi oluşturma
                var image = new Image
                {
                    Id = imageId,
                    FileName = imagePath,
                    FileType = Path.GetExtension(imagePath).Substring(1)
                };

                // Kullanıcı oluşturma
                var user = new AppUser
                {
                    UserName = userRegisterViewModel.Email,
                    Email = userRegisterViewModel.Email,
                    FisrName = userRegisterViewModel.FirstName,
                    LastName = userRegisterViewModel.LastName,
                    ImageId = imageId,
                    Image = image
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

                    return RedirectToAction("Login", "Auth");
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


        
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(userLoginViewModel.Email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, userLoginViewModel.Password, userLoginViewModel.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
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
                return RedirectToAction("Login", "Auth");
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
