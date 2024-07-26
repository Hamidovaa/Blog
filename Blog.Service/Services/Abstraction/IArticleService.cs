using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using Blog.Entity.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstraction
{
    public interface IArticleService
    {
        Task<List<ArticleViewModel>> GetAllArticleWithCategoryNonDeletedAsync();

        Task CreateArticleAsync(ArticleAddViewModel articleAddViewModel);
        Task<List<ArticleViewModel>> GetAllPendingArticlesAsync();
        Task ApproveArticleAsync(Guid articleId);
        Task RejectArticleAsync(Guid articleId);
        Task<List<ArticleViewModel>> GetAllApprovedArticlesAsync();
    }
}
