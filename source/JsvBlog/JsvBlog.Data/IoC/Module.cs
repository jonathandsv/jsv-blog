using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Data.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();

            dic.Add(typeof(Business.Interfaces.IBlogRepository), typeof(BlogRepository));
            return dic;
        }
    }
}
