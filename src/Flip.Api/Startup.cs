using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace flip.api
{
    /// <summary>
    /// The startup class
    /// 
    /// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    /// </summary>
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
