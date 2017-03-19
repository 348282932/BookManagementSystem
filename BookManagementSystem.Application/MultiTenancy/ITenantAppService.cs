using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookManagementSystem.MultiTenancy.Dto;

namespace BookManagementSystem.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
