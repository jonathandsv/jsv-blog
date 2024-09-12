using AutoMapper;
using JsvBlog.Business.Interfaces;
using JsvBlog.Business.ViewModels;

namespace JsvBlog.Business.Services;

public class BlogService : IBlogService
{
    private readonly IBlogRepository _blogRepository;
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public BlogService(IBlogRepository blogRepository, IMapper mapper, IPostRepository postRepository)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
        _postRepository = postRepository;
    }

    public async  Task<List<PostViewModel>> GetAllPostsAsync()
    {
        var result = await _postRepository.GetAllPostAsync();
    }
}