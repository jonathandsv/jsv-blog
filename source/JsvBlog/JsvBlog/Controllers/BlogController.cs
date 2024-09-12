using JsvBlog.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JsvBlog.Controllers;

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
}