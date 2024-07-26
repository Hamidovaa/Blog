using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
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
            var articles=await articleService.GetAllArticleWithCategoryNonDeletedAsync();
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
        //    RedirectToAction("Index", "Home", new {Area="Admin"});

        //    var categories = await categoryService.GetAllCategoriesNonDeleted();
        //    return View(new ArticleAddViewModel { Categories = categories });
        //}

        [HttpGet]
        public async Task<IActionResult> PendingApproval()
        {
            var articles = await articleService.GetAllPendingArticlesAsync();
            return View(articles);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(Guid articleId)
        {
            await articleService.ApproveArticleAsync(articleId);
            // Redirect back to the pending approval page
            return RedirectToAction("PendingApproval");
        }

        [HttpPost]
        public async Task<IActionResult> Reject(Guid articleId)
        {
            await articleService.RejectArticleAsync(articleId);
            // Optionally, set a temp data message for rejection
            TempData["Message"] = "Article rejected.";
            // Redirect back to the pending approval page
            return RedirectToAction("PendingApproval");
        }


    }
}
