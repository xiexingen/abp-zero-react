using XXG.Frm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace XXG.Frm.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(FrmEntityFrameworkCoreDbMigrationsModule),
        typeof(FrmApplicationContractsModule)
        )]
    public class FrmDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
