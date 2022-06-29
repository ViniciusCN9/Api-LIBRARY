using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.domain.Repositories
{
    public interface UserRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
        void CreateUser(User user);
        void UpdateUser(int id, User user);
        void DeleteUser(int id)
    }
}