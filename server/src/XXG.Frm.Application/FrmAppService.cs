using System;
using System.Collections.Generic;
using System.Text;
using XXG.Frm.Localization;
using Volo.Abp.Application.Services;

namespace XXG.Frm
{
    /* Inherit your application services from this class.
     */
    public abstract class FrmAppService : ApplicationService
    {
        protected FrmAppService()
        {
            LocalizationResource = typeof(FrmResource);
        }
    }
}
