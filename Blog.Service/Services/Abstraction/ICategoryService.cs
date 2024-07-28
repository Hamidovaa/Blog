using Blog.Entity.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstraction
{
    public interface ICategoryService
    {
        public Task<List<CategoryViewModel>> GetAllCategoriesNonDeleted();
        Task CreateCategoryAsync(CategoryAddViewModel categoryAddViewModel);
    }
}
