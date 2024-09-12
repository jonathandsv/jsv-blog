using JsvBlog.Business.Interfaces;

namespace JsvBlog.Data.IoC;

public static class Module
{
    public static Dictionary<Type, Type> GetTypes()
    {
        var dic = new Dictionary<Type, Type>();

        dic.Add(typeof(Business.Interfaces.IBlogRepository), typeof(BlogRepository));
        dic.Add(typeof(Business.Interfaces.IPostRepository), typeof(PostRepository));
        return dic;
    }
}
