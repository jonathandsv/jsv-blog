using JsvBlog.Business.ViewModels;

namespace JsvBlog.Business.Interfaces;

public interface IPostService
{
    Task<PostViewModel> GetPostBySlug(string slug);
}