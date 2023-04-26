using System.ComponentModel.DataAnnotations.Schema;

namespace JsvBlog.Business.Entities
{
    [Table("Category")]
    public class Category
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
    }
}
