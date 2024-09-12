using JsvBlog.Business.Entities;
using JsvBlog.Business.Interfaces;
using JsvBlog.Business.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace JsvBlog.Data;

public class PostRepository : IPostRepository
{
    private readonly BlogContext _blogContext;

    public PostRepository(BlogContext blogContext)
    {
        _blogContext = blogContext;
    }

    public async Task GetAllPostAsync()
    {
        var result = await _blogContext.Posts
            .Select(x => new PostViewModel()
            {
                Id = x.Id,
                Content = x.Content
            }).ToListAsync();
        return result;
    }

    public async Task<Post?> GetPostBySlug(string slug)
    {
        return await _blogContext.Posts.FirstOrDefaultAsync(x => x.Slug.Equals(slug));
    }
}