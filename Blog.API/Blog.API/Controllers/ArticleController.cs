using AutoMapper;
using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstraction;
using Blog.Service.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
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

        [HttpGet("AllArticles")]
        public async Task<IActionResult> GetAllArticles()
        {
            var articles = await articleService.GetAllArticlesAsync();
            var articleViewModels = mapper.Map<List<ArticleViewModel>>(articles);
            return Ok(articleViewModels);
        }

        [HttpGet("AllArticlesNonDeleted")]
        public async Task<IActionResult> GetAllArticlesNonDeleted()
        {
            var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsync();
            return Ok(articles);
        }



        [HttpPut("UpdateArticle")]
        public async Task<IActionResult> UpdateArticle([FromBody] ArticleUpdateViewModel articleUpdateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await articleService.UpdateArticleAsync(articleUpdateViewModel);
                return Ok("Article updated successfully.");
            }
            catch (Exception ex)
            {
               
                return StatusCode(500, "An error occurred while updating the article.");
            }
        }


      
        [HttpPost("CreateArticle")]
        public async Task<IActionResult> CreateNewArticle([FromForm] ArticleAddViewModel articleAddViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Guid userId = new Guid("98E993C4-DE3C-4ABA-AFC6-E62046867FDD");
                string createdBy = "sample-created-by"; 

                await articleService.CreateArticleAsync(articleAddViewModel, userId, createdBy);
                return Ok("Article created successfully.");
            }
            catch (Exception ex)
            {
             
                return StatusCode(500, "An error occurred while creating the article.");
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> SafeDeleteArticleAsync(Guid id)
        {
            try
            {
                await articleService.SafeDeleteArticleAsync(id);
                return Ok(new { message = "Article successfully deleted." });
            }
            catch (Exception ex)
            {
                // Log the exception (not shown here for brevity)
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
