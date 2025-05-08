using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UretimPazari.Entities.Models;
using UretimPazari.Repositories.Contracts;

namespace UretimPazari.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateUser(User user)
        {
            CreateUser(user);
        }

        public void DeleteUser(User user)
        {
            DeleteUser(user);
        }

        public IEnumerable<User> GetAllUsers(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public User? GetOneUser(int id, bool trackChanges)
        {
            return FindByCondition(u=>u.UserId==id,trackChanges).SingleOrDefault();
        }

        public void UpdateUser(User user)
        {
            UpdateUser(user);
        }
    }
}
