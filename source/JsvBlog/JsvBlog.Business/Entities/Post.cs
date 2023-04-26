using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Business.Entities
{
    [Table("Post")]
    public class Post
    {
        public Post()
        {
            Categories = new HashSet<Category>();
            Tags = new HashSet<Tag>();
            Comments = new HashSet<Comment>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Excerpt { get; set; } = string.Empty;
        public bool IsPublished { get; set; } = false;
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime PubDate { get; set; }
        public DateTime LastModified { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string UrlContent { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
