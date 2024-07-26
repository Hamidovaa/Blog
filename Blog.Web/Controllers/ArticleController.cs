using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsync();
            return View(articles);
        }
        //[HttpGet]
        //public async Task<IActionResult> Add()
        //{
        //    var categories = await categoryService.GetAllCategoriesNonDeleted();
        //    return View(new ArticleAddViewModel { Categories = categories });
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        //{
        //    await articleService.CreateArticleAsync(articleAddViewModel);
        //    RedirectToAction("Index", "Home", new { Area = "Admin" });

        //    var categories = await categoryService.GetAllCategoriesNonDeleted();
        //    return View(new ArticleAddViewModel { Categories = categories });
        //}

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            var viewModel = new ArticleAddViewModel
            {
                Categories = categories
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {

            var article = new ArticleAddViewModel
            {
                Title = articleAddViewModel.Title,
                Content = articleAddViewModel.Content,
                CategoryId = articleAddViewModel.CategoryId,
                Status = ArticleStatus.PendingApproval
            };

            await articleService.CreateArticleAsync(article);

            // Kullanıcıyı ana sayfaya yönlendirin
            return RedirectToAction("Index", "Home");
        }
    }
}
