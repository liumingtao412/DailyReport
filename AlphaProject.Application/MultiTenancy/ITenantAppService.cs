using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AlphaProject.MultiTenancy.Dto;

namespace AlphaProject.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
