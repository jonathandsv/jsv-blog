using JsvBlog.Business.Constants;

namespace JsvBlog.Data.File.Utils;

public static class HttpUtils
{
    public static Uri CreateListPostRequestUri()
    {
        var server = SystemConstants.URL_REPO_FILE_BLOG;

        var uri = $"/config/list-post.json";

        return new Uri(server + uri);
    }
}
