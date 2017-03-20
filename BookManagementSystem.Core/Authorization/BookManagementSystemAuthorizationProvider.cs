using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace BookManagementSystem.Authorization
{
    public class BookManagementSystemAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions

            var pages = context.GetPermissionOrNull(PermissionNames.Pages);

            if (pages == null)
            {
                pages = context.CreatePermission(PermissionNames.Pages, L("Pages"));
            }

            var users = pages.CreateChildPermission(PermissionNames.Pages_Users, L("Users"));

            var authors = pages.CreateChildPermission(PermissionNames.Pages_Authors, L("Authors"));

            //Host permissions

            var tenants = pages.CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);


        }

        private static LocalizableString L(string name)
        {
            return new LocalizableString(name, BookManagementSystemConsts.LocalizationSourceName);
        }
    }
}
