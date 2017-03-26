using System.Threading.Tasks;
using Abp.Application.Services;
using BookManagementSystem.Roles.Dto;
using System.Collections.Generic;
using Abp.Authorization;
using Abp.Application.Services.Dto;
namespace BookManagementSystem.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        /// <summary>
        /// 获取权限列表
        /// </summary>
        /// <returns></returns>
        PagedResultDto<RoleOutput> List(RoleInput input);

        /// <summary>
        /// 更新权限
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);

        /// <summary>
        /// 更新角色基本信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateRoleInfo(UpdateRoleInfoInput input);

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task InsertRole(InsertRoleInput input);

        /// <summary>
        /// 获取根权限节点
        /// </summary>
        /// <returns></returns>
        IReadOnlyList<Permission> GetRootPermissions();

        /// <summary>
        /// 获取对应角色的权限
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        Task<IReadOnlyList<Permission>> GetPermissionsByRoleId(int roleId);
    }
}
