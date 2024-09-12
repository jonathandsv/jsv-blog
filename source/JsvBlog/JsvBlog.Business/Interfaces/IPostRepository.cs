using JsvBlog.Business.Entities;

namespace JsvBlog.Business.Interfaces;

public interface IPostRepository
{
    Task<Post> GetPostBySlug(string slug);
}
