using JsvBlog.Business.Interfaces;
using JsvBlog.Business.ViewModels;
using JsvBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JsvBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogService _blogService;

        public HomeController(ILogger<HomeController> logger, IBlogService blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        public async IActionResult Index()
        {
            List<PostViewModel> result = await _blogService.GetAllPostsAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}