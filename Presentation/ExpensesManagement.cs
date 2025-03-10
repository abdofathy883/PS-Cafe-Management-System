using PlayStation.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayStation.Application.Services
{
    public partial class ExpensesForm : BaseForm
    {
        private readonly UserService userService ;
        private readonly ExpensesService expensesService ;
        public ExpensesForm(UserService _userService, ExpensesService _expensesService)
        {
            userService = _userService;
            expensesService = _expensesService;

            // Note: I stopped with bug in connecting the user to the expenses, need to fix this bug first
            // Note: I need to implement Update, Delete for Devices.
            // Note: Then Go forward implementing orders and pilling.
            InitializeComponent();
            //ExpensesUser.DataSource = userService.GetAllUsersFromService();
            ExpensesUser.DisplayMember = "UserName";
            ExpensesUser.ValueMember = "ID";
            PopulateExpensesGrid();
        }
        private void PopulateExpensesGrid()
        {
            //var expenses = expensesService.GetAllExpensesFromService();
            //var expensesWithUserNames = expenses.Select(expense => new
            //{
            //    expense.ID,
            //    expense.Description,
            //    expense.ExpensesAmount,
            //    expense.ExpensesDate,
            //    UserName = expense.User != null ? expense.User.UserName : "غير معروف"
            //}).ToList();
            //ExpensesGrid.DataSource = expensesWithUserNames;
            //ExpensesGrid.Columns["ID"].Visible = false;
            //ExpensesGrid.Columns["UserName"].HeaderText = "اسم المستخدم";
        }

        private void AddExpensesBtn_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(ExpensesDescInput.Text) || ExpensesAmountInput.Value < 1)
            //{
            //    MessageBox.Show("لا يمكن اضافة قيم فارغة", "فشل اضافة مصروفات", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    return;
            //}
            //else
            //{
            //    Expenses newExpenses = new Expenses();
            //    newExpenses.Description = ExpensesDescInput.Text;
            //    newExpenses.ExpensesAmount = ExpensesAmountInput.Value;
            //    if (ExpensesUser.SelectedItem is User selectedUser)
            //    {
            //        newExpenses.UserID = selectedUser.ID;
            //        newExpenses.User = expensesService.FindUUser(selectedUser.ID);
            //    }
            //    else
            //    {
            //        MessageBox.Show("يرجى اختيار مستخدم صالح", "فشل اضافة مصروفات", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //        return;
            //    }
            //    newExpenses.ExpensesDate = ExpensesDateTime.Value;
            //    expensesService.AddExpensesFromService(newExpenses);
            //    PopulateExpensesGrid();
            //}
        }
    }
}
