using XXG.Frm.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace XXG.Frm.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class FrmPageModel : AbpPageModel
    {
        protected FrmPageModel()
        {
            LocalizationResourceType = typeof(FrmResource);
        }
    }
}