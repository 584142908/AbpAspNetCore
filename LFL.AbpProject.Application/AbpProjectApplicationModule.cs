using LFL.AbpProject.Application.Contracts;
using LFL.AbpProject.Application.Contracts.Users;
using LFL.AbpProject.Application.Users;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LFL.AbpProject.Application
{
    [DependsOn(typeof(AbpProjectApplicationContractsModule))]
    public class AbpProjectApplicationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //context.Services.AddSingleton<IUserAppService, UserAppService>();

        }
    }
}