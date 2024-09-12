namespace JsvBlog.Business.IoC;

public static class Module
{
    public static Dictionary<Type, Type> GetTypes()
    {
        var dic = new Dictionary<Type, Type>();

        dic.Add(typeof(Interfaces.IBlogService), typeof(Services.BlogService));
        dic.Add(typeof(Interfaces.IPostService), typeof(Services.PostService));
        return dic;
    }
}