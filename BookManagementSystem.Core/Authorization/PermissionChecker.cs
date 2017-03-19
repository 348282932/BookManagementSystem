using Abp.Authorization;
using BookManagementSystem.Authorization.Roles;
using BookManagementSystem.MultiTenancy;
using BookManagementSystem.Users;

namespace BookManagementSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
