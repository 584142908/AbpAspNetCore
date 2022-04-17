using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFL.AbpProject.Application.Contracts.Users
{
    public interface IUserAppService
    {
        Task<UserDto> GetUserAsync(int  Id);
        Task<IEnumerable<UserDto>> GetUserListAsync();
    }
}
