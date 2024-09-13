using JsvBlog.Business.Interfaces;
using JsvBlog.Data.EF;
using JsvBlog.Data.File;

namespace JsvBlog.Data.IoC;

public static class Module
{
    public static Dictionary<Type, Type> GetTypes()
    {
        var dic = new Dictionary<Type, Type>();

        dic.Add(typeof(IBlogRepository), typeof(BlogRepository));
        dic.Add(typeof(IPostRepository), typeof(PostFileRepository));
        return dic;
    }
}
