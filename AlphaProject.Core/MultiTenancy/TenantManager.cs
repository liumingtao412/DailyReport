using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using AlphaProject.Authorization.Roles;
using AlphaProject.Editions;
using AlphaProject.Users;

namespace AlphaProject.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}