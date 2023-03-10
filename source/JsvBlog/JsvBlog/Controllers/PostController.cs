using Microsoft.AspNetCore.Mvc;

namespace JsvBlog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
