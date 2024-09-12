using JsvBlog.Business.Interfaces;

namespace JsvBlog.Data;

public class BlogRepository : IBlogRepository
{
    private readonly BlogContext _blogContext;

    public BlogRepository(BlogContext blogContext)
    {
        _blogContext = blogContext;
    }
}