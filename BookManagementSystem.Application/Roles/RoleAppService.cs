using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using BookManagementSystem.Authorization.Roles;
using BookManagementSystem.Roles.Dto;
using Abp.AutoMapper;
using BookManagementSystem.Authorization;
using System.Collections.Generic;
using Abp.Localization;
using Abp.Dependency;

namespace BookManagementSystem.Roles
{
    /* THIS IS JUST A SAMPLE. */
    public class RoleAppService : BookManagementSystemAppServiceBase,IRoleAppService
    {
        private readonly RoleManager _roleManager;
        private readonly IPermissionManager _permissionManager;

        public RoleAppService(RoleManager roleManager, IPermissionManager permissionManager)
        {
            _roleManager = roleManager;
            _permissionManager = permissionManager;
        }

        public async Task UpdateRolePermissions(UpdateRolePermissionsInput input)
        {
            var role = await _roleManager.GetRoleByIdAsync(input.RoleId);
            var grantedPermissions = _permissionManager
                .GetAllPermissions()
                .Where(p => input.GrantedPermissionNames.Contains(p.Name))
                .ToList();

            await _roleManager.SetGrantedPermissionsAsync(role, grantedPermissions);
        }

        public async Task UpdateRoleInfo(UpdateRoleInfoInput input)
        {
            Role role = await _roleManager.GetRoleByIdAsync(input.RoleId);

            role.Name = input.Name;

            role.DisplayName = input.DisplayName;

            CheckErrors(await _roleManager.UpdateAsync(role));

            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public async Task InsertRole(InsertRoleInput input)
        {
            var role = input.MapTo<Role>();

            CheckErrors(await _roleManager.CreateAsync(role));

            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public List<GetAllPermissionOutPut> GetAllPermission()
        {
            var permissions = PermissionFinder.GetAllPermissions(new BookManagementSystemAuthorizationProvider()).ToList();

            var ss = permissions.Select(s => new GetAllPermissionOutPut { DisplayName = (LocalizableString)s.DisplayName, Name = s.Name, ParentName = s.Parent.Name }).ToList();

            return ss;
        }
    }
}