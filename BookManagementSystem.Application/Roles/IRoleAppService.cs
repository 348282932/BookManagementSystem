using System.Threading.Tasks;
using Abp.Application.Services;
using BookManagementSystem.Roles.Dto;
using System.Collections.Generic;

namespace BookManagementSystem.Roles
{
    public interface IRoleAppService : IApplicationService
    {
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
        /// 获取全部权限节点
        /// </summary>
        /// <returns></returns>
        List<GetAllPermissionOutPut> GetAllPermission();
    }
}
