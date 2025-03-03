using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Infrastructure.Repos
{
    internal class ExpensesRepo
    {
        PSManagementDbContext dbContext = new PSManagementDbContext();
        public List<Expense> GetAllExpensesFromRepo()
        {
            return dbContext.Expenses.ToList();
        }
        public void AddExpensesFromRepo(Expense expenses)
        {
            ///fix attachement of user and expenses
            if (expenses.User != null)
            {
                dbContext.Attach(expenses.User);
            }
            dbContext.Expenses.Add(expenses);
            dbContext.SaveChanges();
        }
        public User FindUser(int id)
        {
            return dbContext.Users.Find(id);
        }
    }
}
