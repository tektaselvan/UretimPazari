using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;

namespace UretimPazari.Repositories.Contracts
{
    public interface IUserRepository:IRepositoryBase<User>
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);
        User? GetOneUser(int id, bool trackChanges);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
