using JsvBlog.Business.Entities;

namespace JsvBlog.Business.Interfaces;

public interface IPostRepository
{
    Task GetAllPostAsync();
    Task<Post> GetPostBySlug(string slug);
}
