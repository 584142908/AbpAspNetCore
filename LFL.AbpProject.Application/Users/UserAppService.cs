﻿using LFL.AbpProject.Application.Contracts.Users;

namespace LFL.AbpProject.Application.Users
{
    public class UserAppService : IUserAppService
    {
        public async Task<UserDto> GetUserAsync(int Id)
        {
            await Task.CompletedTask;
            return new UserDto() {
                Id = Id,
                UserName = "刘福来",
                Password ="1111",
                Email ="dalk"

            };
        }

        public async Task<IEnumerable<UserDto>> GetUserListAsync()
        {
            await Task.CompletedTask;
            return new List<UserDto>()
            {
                new UserDto() {
                Id =1,
                UserName = "刘福来列表",
                Password = "1111",
                Email = "dalk"
                }
            };
        }
    }
}
