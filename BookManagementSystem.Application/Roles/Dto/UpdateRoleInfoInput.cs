using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Roles.Dto
{
    public class UpdateRoleInfoInput
    {
        [Range(1, int.MaxValue)]
        public int RoleId{ get; set; }

        [MaxLength(32)]
        public string Name { get; set; }

        [MaxLength(64)]
        public string DisplayName { get; set; }
    }
}
