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
    public class ExpensesService
    {
        private readonly IRepository<Expense> _expenseRepository;
        private readonly IRepository<User> _userRepository;
        public ExpensesService(IRepository<Expense> expenseRepository, IRepository<User> userRepository)
        {
            _expenseRepository = expenseRepository;
            _userRepository = userRepository;
        }
        public List<Expense> GetAllExpensesFromService()
        {
            return _expenseRepository.GetAll().ToList();
        }
        public void AddExpensesFromService(Expense expense)
        {
            _expenseRepository.Add(expense);

        }
        public User FindUUser(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
