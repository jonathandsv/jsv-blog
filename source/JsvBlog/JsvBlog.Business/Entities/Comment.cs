using System.ComponentModel.DataAnnotations.Schema;

namespace JsvBlog.Business.Entities
{
    [Table("Comment")]
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAdmin { get; set; } = false;
        public DateTime PubDate { get; set; } = DateTime.UtcNow;

        public Post Post { get; set; }
    }
}
