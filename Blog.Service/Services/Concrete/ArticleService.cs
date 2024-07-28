﻿using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Entity.ViewModels.Categories;
using Blog.Service.Services.Abstraction;
using Microsoft.EntityFrameworkCore;
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

		public async Task CreateArticleAsync(ArticleAddViewModel articleAddViewModel, Guid userId, string createdBy)
		{
            var article = new Article
            {
                Title = articleAddViewModel.Title,
                Content = articleAddViewModel.Content,
                CategoryId = articleAddViewModel.CategoryId,
                UserId = userId,
                Status = ArticleStatus.PendingApproval,
                ImagePath=articleAddViewModel.ImagePath,
                CreatedBy = createdBy,
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
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => x.Status == ArticleStatus.PendingApproval && !x.IsDeleted, x => x.Category);
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
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => x.Status == ArticleStatus.Approved, x => x.Category, x => x.User);
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

        public async Task<ArticleViewModel> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await _unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id==articleId, x => x.Category);
            var map = mapper.Map<ArticleViewModel>(article);
            return map;
        }

        public async Task UpdateArticleAsync(ArticleUpdateViewModel articleUpdateViewModel)
        {
            var article= await _unitOfWork.GetRepository<Article>().GetAsync(x=>!x.IsDeleted && x.Id==articleUpdateViewModel.Id, x=>x.Category);

            article.Title= articleUpdateViewModel.Title;
            article.Content= articleUpdateViewModel.Content;
            article.CategoryId= articleUpdateViewModel.CategoryId;
            article.Status = ArticleStatus.PendingApproval;

            await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await _unitOfWork.SaveAsync();
        }

        public async Task SafeDeleteArticleAsync(Guid articleId)
        {
            var article=await _unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
            if (article != null)
            {
                article.IsDeleted = true;
                article.DeletedDate = DateTime.Now;

                await _unitOfWork.GetRepository<Article>().UpdateAsync(article);
                await _unitOfWork.SaveAsync();
            }
              
        }

		public async Task<List<ArticleViewModel>> GetUserArticlesAsync(Guid userId)
		{
			var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(x => x.UserId == userId && !x.IsDeleted, x => x.Category);
			var map = mapper.Map<List<ArticleViewModel>>(articles);
			return map;
		}

        public async Task<List<ArticleViewModel>> GetAllNonDeletedApprovedArticlesAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(
                x => !x.IsDeleted && x.Status == ArticleStatus.Approved,
                x => x.Category, x => x.User);

            var map = mapper.Map<List<ArticleViewModel>>(articles);
            return map;
        }


        public async Task CreateArticleAsync(ArticleAddViewModel articleAddViewModel, Guid userId)
        {
            var article = new Article
            {
                Title = articleAddViewModel.Title,
                Content = articleAddViewModel.Content,
                CategoryId = articleAddViewModel.CategoryId,
                UserId = userId,
                Status = ArticleStatus.PendingApproval,
                ImagePath = articleAddViewModel.ImagePath,
             
            };

            await _unitOfWork.GetRepository<Article>().AddAsync(article);
            await _unitOfWork.SaveAsync();
        }



        public async Task<List<ArticleViewModel>> GetArticlesByUserAsync(Guid id)
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(
                x => x.UserId == id && !x.IsDeleted,
                x => x.Category
            );

            if (articles == null || !articles.Any())
            {
                return new List<ArticleViewModel>(); // Boş bir liste döndür
            }

            return mapper.Map<List<ArticleViewModel>>(articles);
        }

        public async Task<Guid?> GetUserIdByUsernameAsync(string username)
        {
            var user = await _unitOfWork.GetRepository<Article>().GetAsync(u => u.User.UserName == username);
            return user?.Id;
        }

        public async Task<List<ArticleViewModel>> GetArticlesByUserIdAsync(Guid id)
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync(
                x => x.UserId == id && !x.IsDeleted,
                x => x.Category
            );
            var mappedArticles = mapper.Map<List<ArticleViewModel>>(articles);
            return mappedArticles;
        }







        public async Task<IEnumerable<Article>> GetAllArticlesAsync()
        {
            return await _unitOfWork.GetRepository<Article>().GetAllAsync();
        }

      
    }
}
