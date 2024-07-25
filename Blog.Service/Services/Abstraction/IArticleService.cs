using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstraction
{
    public interface IArticleService
    {
        Task<List<ArticleViewModel>> GetAllArticleAsync();
    }
}
