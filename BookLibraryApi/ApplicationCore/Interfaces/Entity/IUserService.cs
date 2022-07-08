using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.Entity
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<IEnumerable<User>> GetAllUsersWith();
        Task<User> GetUserById(int id);
        Task<User> GetUserByName(string name);
        Task<User> AddUser(User user);
        Task UpdateUser(User user);
        Task DeleteUserById(int id);
    }
}
