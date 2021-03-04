using XXG.Frm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XXG.Frm.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class FrmController : AbpController
    {
        protected FrmController()
        {
            LocalizationResource = typeof(FrmResource);
        }
    }
}