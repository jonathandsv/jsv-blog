using JsvBlog.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace JsvBlog.Data.EF;

public partial class BlogContext : DbContext
{
    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {

    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Comment> Comments { get; set; }
}