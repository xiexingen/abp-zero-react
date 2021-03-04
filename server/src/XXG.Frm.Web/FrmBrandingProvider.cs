using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace XXG.Frm.Web
{
    [Dependency(ReplaceServices = true)]
    public class FrmBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Frm";
    }
}
