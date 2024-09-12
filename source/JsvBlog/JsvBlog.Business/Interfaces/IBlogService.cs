using JsvBlog.Business.ViewModels;

namespace JsvBlog.Business.Interfaces;

public interface IBlogService
{
    Task<List<PostViewModel>> GetAllPostsAsync();
}