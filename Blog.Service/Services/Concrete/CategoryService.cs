using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Categories;
using Blog.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<CategoryViewModel>> GetAllCategoriesNonDeleted()
        {
            var categories= await unitOfWork.GetRepository<Category>().GetAllAsync(x=> !x.IsDeleted);
            var map=mapper.Map<List<CategoryViewModel>>(categories);
            return map;
        }

        public async Task CreateCategoryAsync(CategoryAddViewModel categoryAddViewModel)
        {
            var category = new Category
            {
                Name = categoryAddViewModel.Name,
            };

            await unitOfWork.GetRepository<Category>().AddAsync(category);
            await unitOfWork.SaveAsync();
        }


    }
}
