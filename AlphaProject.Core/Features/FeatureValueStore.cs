using Abp.Application.Features;
using AlphaProject.Authorization.Roles;
using AlphaProject.MultiTenancy;
using AlphaProject.Users;

namespace AlphaProject.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}