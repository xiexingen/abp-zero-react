using Volo.Abp.Modularity;

namespace XXG.Frm
{
    [DependsOn(
        typeof(FrmApplicationModule),
        typeof(FrmDomainTestModule)
        )]
    public class FrmApplicationTestModule : AbpModule
    {

    }
}