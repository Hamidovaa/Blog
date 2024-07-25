using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<ArticleViewModel>> GetAllArticleAsync()
        {
            var articles= await _unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleViewModel>>(articles);
            return map;
        }
    }
}
