using ImplementDependencyInjection.Repository;
using Microsoft.AspNetCore.Builder;

namespace ImplementDependencyInjection
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IBookRepository, BookRepository>();
        }

        public void configure(IApplicationBuilder app , IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
