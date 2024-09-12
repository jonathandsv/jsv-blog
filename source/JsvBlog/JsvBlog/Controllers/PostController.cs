using JsvBlog.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JsvBlog.Controllers;

public class PostController : Controller
{
    private readonly IPostService _postService;

    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("/post/{slug?}")]
    public async Task<IActionResult> Index(string slug)
    {
        var postViewModel = await _postService.GetPostBySlug(slug);

        return postViewModel is null ? NotFound() : View(postViewModel);
    }
}