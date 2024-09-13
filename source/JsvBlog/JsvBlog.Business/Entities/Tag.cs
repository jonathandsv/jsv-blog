using System.ComponentModel.DataAnnotations.Schema;

namespace JsvBlog.Business.Entities
{
    [Table("Tag")]
    public class Tag
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
