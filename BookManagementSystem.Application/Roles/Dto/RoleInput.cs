using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.Roles.Dto
{
    public class RoleInput : IPagedResultRequest
    {
        public const int DefaultPageSize = 10;

        [Range(1, int.MaxValue)]
        public int MaxResultCount { get; set; }

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public RoleInput()
        {
            MaxResultCount = DefaultPageSize;
        }
    }
}
