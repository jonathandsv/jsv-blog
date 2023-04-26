using AutoMapper;
using JsvBlog.Business.Interfaces;
using JsvBlog.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Business.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<PostViewModel> GetPostBySlug(string slug)
        {
            return _mapper.Map<PostViewModel>(await _blogRepository.GetPostBySlug(slug));
        }
    }
}
