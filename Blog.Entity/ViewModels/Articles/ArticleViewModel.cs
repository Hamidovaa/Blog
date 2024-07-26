﻿using Blog.Entity.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.ViewModels.Articles
{
    public class ArticleViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public CategoryViewModel Category { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
