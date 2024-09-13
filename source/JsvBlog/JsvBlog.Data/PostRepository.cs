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

    public async Task<List<PostViewModel>> GetAllPostAsync()
    {
        return await _blogContext.Posts
            .Select(x => new PostViewModel()
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
                Excerpt = x.Excerpt,
                IsPublished = x.IsPublished,
                CreateDate = x.CreateDate,
                PubDate = x.PubDate,
                LastModified = x.LastModified,
                Slug = x.Slug,
                UrlContent = x.UrlContent,
                Categories = x.Categories
                    .Select(cat => new 
                        CategoryViewModel(cat.Id, cat.Descricao)),
                Tags = x.Tags.Select(tag => new 
                    TagViewModel(tag.Id, tag.Descricao))
            }).ToListAsync();
    }

    public async Task<Post?> GetPostBySlug(string slug)
    {
        return await _blogContext.Posts.FirstOrDefaultAsync(x => x.Slug.Equals(slug));
    }
}