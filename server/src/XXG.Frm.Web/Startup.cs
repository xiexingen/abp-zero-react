using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace XXG.Frm.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<FrmWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
