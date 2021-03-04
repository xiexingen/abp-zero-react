using XXG.Frm.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace XXG.Frm.Permissions
{
    public class FrmPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FrmPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FrmPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FrmResource>(name);
        }
    }
}
