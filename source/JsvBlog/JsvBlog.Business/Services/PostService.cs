using AutoMapper;
using JsvBlog.Business.Interfaces;
using JsvBlog.Business.ViewModels;

namespace JsvBlog.Business.Services;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public PostService(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<PostViewModel> GetPostBySlug(string slug)
    {
        return _mapper.Map<PostViewModel>(await _postRepository.GetPostBySlug(slug));
    }
}