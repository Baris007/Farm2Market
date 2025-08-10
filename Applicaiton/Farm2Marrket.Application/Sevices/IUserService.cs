using Farm2Market.Domain.Entities;
using Farm2Marrket.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2Marrket.Application.Sevices
{
    public interface IUserService
    {
        Task AddUser(User user );
        Task<bool> ConfirmNumber(string id, int number);

        Task<List<UserListDto>> GetActiveUsersAsync();
    

    }
}
