using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace AlphaProject
{
    [DependsOn(typeof(AlphaProjectCoreModule), typeof(AbpAutoMapperModule))]
    public class AlphaProjectApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
