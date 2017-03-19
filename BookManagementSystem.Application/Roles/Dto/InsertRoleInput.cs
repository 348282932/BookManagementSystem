using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Roles.Dto
{
    public class InsertRoleInput
    {
        [MaxLength(32)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string DisplayName { get; set; }

        [Required]
        public List<string> GrantedPermissionNames { get; set; }
    }
}
