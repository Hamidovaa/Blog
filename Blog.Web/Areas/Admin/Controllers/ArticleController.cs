using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstraction;
using Blog.Service.Services.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly UserManager<AppUser> userManager;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, UserManager<AppUser> userManager)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        { 
            var articles=await articleService.GetAllArticleWithCategoryNonDeletedAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ArticleAddViewModel
            {
                Categories = await categoryService.GetAllCategoriesNonDeleted() // Kategorileri al ve modele ekle
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddViewModel articleAddViewModel)
        {

            var userId = userManager.GetUserId(User);
            await articleService.CreateArticleAsync(articleAddViewModel, new Guid(userId));
            return Ok();
        }


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

        [HttpPost]
        public async Task<IActionResult> Delete(Guid articleId)
        {
            await articleService.SafeDeleteArticleAsync(articleId);

            return Json(new { success = true });
        }


    }
}
