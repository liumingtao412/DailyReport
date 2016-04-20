using System.Threading.Tasks;
using Abp.Application.Services;
using AlphaProject.Users.Dto;

namespace AlphaProject.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}