using JsvBlog.Business.AutoMapper;

namespace JsvBlog.Extensions
{
    /// <summary>
    /// AutoMapper Extension
    /// </summary>
    public static class AutoMapperSetupExtensions
    {
        /// <summary>
        /// Extensão autoMapper
        /// </summary>
        /// <param name="services"></param>
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Registering Mappings automatically only works if the 
            // Automapper Profile classes are in ASP.NET project
            AutoMapperConfig.RegisterMappings();
        }
    }
}
