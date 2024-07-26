using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Entity.ViewModels.Categories;
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

        public async Task CreateArticleAsync(ArticleAddViewModel articleAddViewModel)
        {
            var userId = Guid.Parse("5D5A55F1-FE1C-4A59-B737-6A6DBFF724E1");

            var article = new Article
            {
                Title = articleAddViewModel.Title,
                Content = articleAddViewModel.Content,
                CategoryId = articleAddViewModel.CategoryId,
                UserId= userId,
                Status = ArticleStatus.PendingApproval
            };

            await _unitOfWork.GetRepository<Article>().AddAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleViewModel>> GetAllArticleWithCategoryNonDeletedAsync()
        {
            var articles= await _unitOfWork.GetRepository<Article>().GetAllAsync(x=> !x.IsDeleted, x=>x.Category);
            var map = mapper.Map<List<ArticleViewModel>>(articles);
            return map;
        }


        public async Task<List<ArticleViewModel>> GetAllPendingArticlesAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => x.Status == ArticleStatus.PendingApproval, x => x.Category);
            var map = mapper.Map<List<ArticleViewModel>>(articles);
            return map;
        }

        public async Task ApproveArticleAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
            if (article != null)
            {
                article.Status = ArticleStatus.Approved;
                await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
                await _unitOfWork.SaveAsync();
            }
        }

        public async Task<List<ArticleViewModel>> GetAllApprovedArticlesAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => x.Status == ArticleStatus.Approved, x => x.Category);
            var map = mapper.Map<List<ArticleViewModel>>(articles);
            return map;
        }

        public async Task RejectArticleAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
            if (article != null)
            {
                article.Status = ArticleStatus.Rejected;
                await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
                await _unitOfWork.SaveAsync();
            }
        }

       
    }
}
