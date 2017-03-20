using Abp.Localization;

namespace BookManagementSystem.Roles.Dto
{
    public class GetAllPermissionOutPut
    {
        public string ParentName { get; set; }

        public LocalizableString DisplayName { get; set; }

        public string Name { get; set; }
    }
}
