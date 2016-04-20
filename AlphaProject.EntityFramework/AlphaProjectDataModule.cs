using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using AlphaProject.EntityFramework;

namespace AlphaProject
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AlphaProjectCoreModule))]
    public class AlphaProjectDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
