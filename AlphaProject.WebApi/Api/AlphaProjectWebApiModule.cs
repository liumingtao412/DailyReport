using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace AlphaProject.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AlphaProjectApplicationModule))]
    public class AlphaProjectWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AlphaProjectApplicationModule).Assembly, "app")
                .Build();
            //通过上述设定，将所有的Application层中的Service公布为WebAPI，其访问路径如下
            //{主机地址}/api/services/app/｛Service类名称｝/｛方法名称｝
            //http://localhost:61759/api/services/app/person/GetAllPersons

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
        }
    }
}
