using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using BookManagementSystem.Authorization.Roles;
using BookManagementSystem.Roles.Dto;
using Abp.AutoMapper;
using BookManagementSystem.Authorization;
using System.Collections.Generic;
using Abp.Linq.Extensions;
using Abp.Application.Services.Dto;

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

        public IReadOnlyList<Permission> GetRootPermissions()
        {
            return PermissionFinder.GetAllPermissions(new BookManagementSystemAuthorizationProvider()).Take(1).ToList();
        }

        public async Task<IReadOnlyList<Permission>> GetPermissionsByRoleId(int roleId)
        {
            return await _roleManager.GetGrantedPermissionsAsync(roleId);
        }

        public PagedResultDto<RoleOutput> List(RoleInput input)
        {
            var rolesCount = _roleManager.Roles.Count();

            var roles = _roleManager.Roles.OrderByDescending(p => p.CreationTime).PageBy(input);

            roles.Select(s => new RoleOutput
            {
                RoleId = s.Id,
                RoleName = s.DisplayName,
                
            });

            return new PagedResultDto<RoleOutput>(
                rolesCount,
                roles.MapTo<List<RoleOutput>>()
                );
        }
    }
}