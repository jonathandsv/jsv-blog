using JsvBlog.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Business.Interfaces
{
    public interface IBlogRepository
    {
        Task<Post> GetPostBySlug(string slug);
    }
}
