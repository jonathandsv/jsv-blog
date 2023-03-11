using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsvBlog.Business.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetType()
        {
            var dic = new Dictionary<Type, Type>();

            dic.Add(typeof(Interfaces.IBlogService), typeof(Interfaces.IBlogService));
            return dic;
        }
    }
}
