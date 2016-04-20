using Abp.Authorization.Roles;
using AlphaProject.MultiTenancy;
using AlphaProject.Users;

namespace AlphaProject.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}