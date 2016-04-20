using Abp.Authorization;
using AlphaProject.Authorization.Roles;
using AlphaProject.MultiTenancy;
using AlphaProject.Users;

namespace AlphaProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
