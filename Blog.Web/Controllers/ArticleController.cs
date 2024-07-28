using AutoMapper;
using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
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
            if (User.Identity.IsAuthenticated)
            {
                var categories = await categoryService.GetAllCategoriesNonDeleted();
                var viewModel = new ArticleAddViewModel
                {
                    Categories = categories
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

            var article = new ArticleAddViewModel
            {
                Title = articleAddViewModel.Title,
                Content = articleAddViewModel.Content,
                CategoryId = articleAddViewModel.CategoryId,
                Status = ArticleStatus.PendingApproval
            };

            await articleService.CreateArticleAsync(article);

            return RedirectToAction("Index", "Home");
        }

        //[HttpGet]
        //public async Task<IActionResult> Waiting()
        //{

        //    var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsync();
        //    return View(articles);
        //}

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

        public async Task<IActionResult> Delete(Guid articleId)
        {
            await articleService.SafeDeleteArticleAsync(articleId);

            return RedirectToAction("Index", "Article");
        }
    }
}
