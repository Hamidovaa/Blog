using AutoMapper;
using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstraction;
using Blog.Service.Services.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace Blog.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
			string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			if (string.IsNullOrEmpty(userId))
			{
				// Kullanıcı oturum açmamışsa veya NameIdentifier talebi yoksa
				return RedirectToAction("Login", "Auth"); // Doğru login sayfasına yönlendirin
			}

			Guid userGuid;
			if (!Guid.TryParse(userId, out userGuid))
			{
				// Kullanıcı oturum açmamışsa veya NameIdentifier talebi yoksa
				return RedirectToAction("Login", "Auth"); // Doğru login sayfasına yönlendirin
			}

			var userArticles = await articleService.GetUserArticlesAsync(userGuid);
			return View(userArticles);
		}


     

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (User.Identity.IsAuthenticated)
            {
                var categories = await categoryService.GetAllCategoriesNonDeleted();
                var viewModel = new ArticleAddViewModel
                {
                    Categories = categories,
               
                };
                return View(viewModel);
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }

          
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {
            if (User.Identity.IsAuthenticated)
            {
                string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (Guid.TryParse(userId, out Guid userGuid))
                {
                    string createdBy = User.Identity.Name; // Kullanıcı adını buradan alıyoruz

                    string uniqueFileName = null;

                    if (articleAddViewModel.Image != null)
                    {
                        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + articleAddViewModel.Image.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await articleAddViewModel.Image.CopyToAsync(fileStream);
                        }
                        articleAddViewModel.ImagePath = "/images/" + uniqueFileName;
                    }

                    await articleService.CreateArticleAsync(articleAddViewModel, userGuid, createdBy);
                    return RedirectToAction("Index", "Article");
                }
            }

            return RedirectToAction("Login", "Auth");
        }




        [HttpGet]
        public async Task<IActionResult> Update(Guid articleId)
        {
            var article=await articleService.GetArticleWithCategoryNonDeletedAsync(articleId);
            var categories= await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdateViewModel=mapper.Map<ArticleUpdateViewModel>(article);

            articleUpdateViewModel.Categories=categories;

            return View(articleUpdateViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ArticleUpdateViewModel articleUpdateViewModel)
        {
            await articleService.UpdateArticleAsync(articleUpdateViewModel);

            var categories = await categoryService.GetAllCategoriesNonDeleted();


            articleUpdateViewModel.Categories = categories;

            return RedirectToAction("Index", "Article");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid articleId)
        {
            await articleService.SafeDeleteArticleAsync(articleId);

            return Json(new { success = true });
        }

      

    }
}
