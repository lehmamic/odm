using Microsoft.AspNet.Builder;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;

namespace Odm.Server.Web
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
            var configuration = new Configuration()
                .AddJsonFile("Config.json")
                .AddEnvironmentVariables();

            app.UseServices(services =>
            {
                // Add MVC services to the service container
                services.AddMvc();
            });

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
