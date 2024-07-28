using Blog.Entity.ViewModels.Categories;
using Blog.Service.Services.Abstraction;
using Blog.Service.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryAddViewModel categoryAddViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await categoryService.CreateCategoryAsync(categoryAddViewModel);
                return Ok("Category created successfully.");
            }
            catch (Exception ex)
            {
                // Hata günlüğü kaydı ekleyebilirsiniz
                return StatusCode(500, $"An error occurred while creating the category: {ex.Message}");
            }
        }


        [HttpGet("AllCategoryNonDeleted")]
        public async Task<ActionResult<List<CategoryViewModel>>> GetAllCategoriesNonDeleted()
        {
            try
            {
                var categories = await categoryService.GetAllCategoriesNonDeleted();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
