//using PlayStation.Domain.Models;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Infrastructure.Repos
{
    internal class UserRepo
    {
        private readonly PSManagementDbContext dbContext = new();
        public List<User> GetAllUsersFromRepo()
        {
            return dbContext.Users.ToList();
        }
        public void AddUserFromRepo(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        public void UpdateUserFromRepo(User user)
        {
            var ExistingUser = dbContext.Users.Find(user.Id);
            if (ExistingUser != null)
            {
                ExistingUser.Name = user.Name;
                ExistingUser.Password = user.Password;
                ExistingUser.Role = user.Role;
                dbContext.SaveChanges();
            }
        }
        public void DeleteUserFromRepo(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}
