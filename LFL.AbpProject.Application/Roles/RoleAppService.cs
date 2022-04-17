using LFL.AbpProject.Application.Contracts.Roles;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace LFL.AbpProject.Application.Roles
{
    [Dependency(ServiceLifetime.Transient)]
    public class RoleAppService : IRoleAppService//, ITransientDependency//IApplicationService
    {
        public async Task<RoleDto> GetRoleAsync(int Id)
        {
            await Task.CompletedTask;
            return new RoleDto() {
                Id = Id,
                RoleName = "刘福来",
                Password ="1111",
                Email ="dalk"

            };
        }

        public async Task<IEnumerable<RoleDto>> GetRoleListAsync()
        {
            await Task.CompletedTask;
            return new List<RoleDto>()
            {
                new RoleDto() {
                Id =1,
                RoleName = "刘福来列表",
                Password = "1111",
                Email = "dalk"
                }
            };
        }
    }
}
