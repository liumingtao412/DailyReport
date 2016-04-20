using System.Threading.Tasks;
using Abp.Application.Services;
using AlphaProject.Roles.Dto;

namespace AlphaProject.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
