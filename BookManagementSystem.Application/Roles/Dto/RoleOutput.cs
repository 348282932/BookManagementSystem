using System;
using System.Collections.Generic;

namespace BookManagementSystem.Roles.Dto
{
    public class RoleOutput
    {
        public int RoleId { get; set; }

        public string DisplayName { get; set; }

        public int PermissionCount { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
