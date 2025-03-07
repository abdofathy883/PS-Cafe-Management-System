//using PlayStation.Domain.Models;
using PlayStation.Infrastructure.Repos;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Infrastructure
{
    internal class UserService
    {
        private UserRepo UserRepo = new UserRepo();
        public List<User> GetAllUsersFromService()
        {
            return UserRepo.GetAllUsersFromRepo();
        }
        public void AddUserFromService(User user)
        {
            UserRepo.AddUserFromRepo(user);
        }
        public void UpdateUserFromService(User user)
        {
            UserRepo.UpdateUserFromRepo(user);
        }
        public void DeleteUserFromService(User user)
        {
            UserRepo.DeleteUserFromRepo(user);
        }
    }
}
