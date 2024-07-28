using Blog.Entity.Entities;
using Blog.Entity.ViewModels.Categories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.ViewModels.Articles
{
    public class ArticleAddViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }
        public IList<CategoryViewModel> Categories { get; set; }
        public ArticleStatus? Status { get; set; }

        // Kullanıcı bilgileri
        public string? CreatedBy { get; set; }

        public IFormFile Image { get; set; }

        public string ImagePath { get; set; }
       
    }
}
