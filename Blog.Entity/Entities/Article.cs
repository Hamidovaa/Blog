using Blog.Core.Entities;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public enum ArticleStatus
    {
        PendingApproval,
        Approved,
        Rejected
    }

    public class Article : EntityBase
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;
        public Guid CategoryId { get; set; }
        public Category Category {  get; set; }
        public Guid? ImageId { get; set; }
        public Image Image {  get; set; }

        public Guid  UserId { get; set; }
        public AppUser User { get; set; }
        public ArticleStatus? Status { get; set; }
    }
}

