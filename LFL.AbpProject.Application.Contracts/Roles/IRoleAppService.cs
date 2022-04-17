using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace LFL.AbpProject.Application.Contracts.Roles
{
    public interface IRoleAppService:IRemoteService
    {
        Task<RoleDto> GetRoleAsync(int  Id);
        Task<IEnumerable<RoleDto>> GetRoleListAsync();
    }
}
