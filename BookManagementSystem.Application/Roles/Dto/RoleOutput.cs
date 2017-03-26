using System.Collections.Generic;

namespace BookManagementSystem.Roles.Dto
{
    public class RoleOutput
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string PermissionCount { get; set; }

        public string PermissionNames { get; set; }

        public string PermissionValues { get; set; }
    }
}
