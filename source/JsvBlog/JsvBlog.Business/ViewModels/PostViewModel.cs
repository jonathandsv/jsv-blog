using JsvBlog.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Business.ViewModels
{
    public class PostViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Excerpt { get; set; } = string.Empty;
        public bool IsPublished { get; set; } = false;
        public DateTime CreateDate { get; set; }
        public DateTime PubDate { get; set; }
        public DateTime LastModified { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string UrlContent { get; set; } = string.Empty;

        public List<CategoryViewModel> Categories { get; set; }
        public List<TagViewModel> Tags { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
