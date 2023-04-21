using JsvBlog.Data;
using Microsoft.EntityFrameworkCore;

namespace JsvBlog.Extensions
{
    public static class DbContextExtensions
    {
        public static void AddDataBase(this IServiceCollection services, IConfiguration configuration) 
        {
            string connectionString = configuration.GetConnectionString("BLOGDB");
            services.AddDbContext<BlogContext>(options =>
                options
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging());
        }
    }
}
