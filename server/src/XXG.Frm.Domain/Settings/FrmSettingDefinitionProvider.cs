using Volo.Abp.Settings;

namespace XXG.Frm.Settings
{
    public class FrmSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FrmSettings.MySetting1));
        }
    }
}
