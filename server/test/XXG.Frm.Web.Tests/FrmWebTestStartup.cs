using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace XXG.Frm
{
    public class FrmWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<FrmWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}