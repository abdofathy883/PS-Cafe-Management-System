//using PlayStation.Domain.Models;
using PlayStation.Infrastructure.Repos;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    public class UserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetUserByIdFromService(int id)
        {
            return _userRepository.GetById(id);
        }
        public User? GetUserByUserFromService(string userName)
        {
            return _userRepository.Find(u=>u.Name==userName).FirstOrDefault();
        }
        public List<User> GetAllUsersFromService()
        {
            //return (List<User>)_userRepository.GetAll().Select(u => new User
            //{
            //    Name = u.Name,
            //    Role = u.Role,
            //    Expenses = u.Expenses.Where(e => e.Id == u.Id).Sum(e => (decimal?)e.Amount)

            //}).ToList();
            return _userRepository.GetAll().ToList();
        }
        public List<User> GetUsersWithDataFromService()
        {
            return (List<User>)_userRepository.GetUsersWithData();
        }
        public void AddUserFromService(User user)
        {
            _userRepository.Add(user);
        }
        public void UpdateUserFromService(User user)
        {
            _userRepository.Update(user);
        }
        public void DeleteUserFromService(User user)
        {
            _userRepository.DeleteById(user.Id);
        }
        public bool IsUsereNameIsUsed(string name)
        {
            return _userRepository.IsUsed(d => d.Name == name);
        }
    }
}
