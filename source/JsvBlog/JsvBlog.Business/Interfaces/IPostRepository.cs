using JsvBlog.Business.Entities;
using JsvBlog.Business.ViewModels;

namespace JsvBlog.Business.Interfaces;

public interface IPostRepository
{
    Task<List<PostViewModel>> GetAllPostAsync();
    Task<PostViewModel> GetPostBySlug(string slug);
}
