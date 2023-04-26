using JsvBlog.Business.Entities;
using JsvBlog.Business.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Data
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _blogContext;

        public BlogRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public async Task<Post> GetPostBySlug(string slug)
        {
            return await _blogContext.Posts.FirstOrDefaultAsync(x => x.Slug.Equals(slug));
        }
    }
}
