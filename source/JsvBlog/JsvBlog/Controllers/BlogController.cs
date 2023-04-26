using JsvBlog.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JsvBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blog;

        public BlogController(IBlogService blog)
        {
            _blog = blog;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/blog/{slug?}")]
        public async Task<IActionResult> Index(string slug)
        {
            var postViewModel = await _blog.GetPostBySlug(slug);

            return postViewModel is null ? this.NotFound() : (IActionResult)this.View(postViewModel);
        }
    }
}
