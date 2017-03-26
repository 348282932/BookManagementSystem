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

            users.CreateChildPermission(PermissionNames.Pages_Users_Roles, L("Roles"));

            var authors = pages.CreateChildPermission(PermissionNames.Pages_Authors, L("Authors"));

            var books = authors.CreateChildPermission(PermissionNames.Pages_Authors_Books, L("Books"));

            books.CreateChildPermission(PermissionNames.Pages_Authors_Books_ZhangJie, L("ZhangJie"));

            //Host permissions

            var tenants = pages.CreateChildPermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);


        }

        private static LocalizableString L(string name)
        {
            return new LocalizableString(name, BookManagementSystemConsts.LocalizationSourceName);
        }
    }
}
