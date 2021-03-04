using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace XXG.Frm.EntityFrameworkCore
{
    [DependsOn(
        typeof(FrmEntityFrameworkCoreModule)
        )]
    public class FrmEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FrmMigrationsDbContext>();
        }
    }
}
