using XXG.Frm.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace XXG.Frm
{
    [DependsOn(
        typeof(FrmEntityFrameworkCoreTestModule)
        )]
    public class FrmDomainTestModule : AbpModule
    {

    }
}