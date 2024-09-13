using JsvBlog.Business.Constants;
using JsvBlog.Business.Interfaces;
using JsvBlog.Business.ViewModels;
using JsvBlog.Data.File.Utils;
using System.Text.Json;

namespace JsvBlog.Data.File;

public class PostFileRepository : IPostRepository
{
    private readonly HttpClient _httpClient;

    public PostFileRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<PostViewModel>> GetAllPostAsync()
    {
        using var response = await _httpClient.GetAsync(HttpUtils.CreateListPostRequestUri());
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var posts = JsonSerializer.Deserialize<List<PostViewModel>>(result, options);
            return posts;
        }
        else
        {
            return new List<PostViewModel>();
        }
    }

    public async Task<PostViewModel> GetPostBySlug(string slug)
    {
        var posts = await GetAllPostAsync();
        var post = posts.FirstOrDefault(x => x.Slug == slug);
        post.UrlContent = MakeUrlContent(post.Slug);
        return post;
    }

    public string MakeUrlContent(string slug)
    {
        var server = SystemConstants.URL_REPO_FILE_BLOG;

        var uri = $"/markdown-files/{slug}.md";

        return server + uri;
    }
}