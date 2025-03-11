using PlayStation.Models;
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
        private readonly ExpensesService expensesService;
        public ExpensesForm(ExpensesService _expensesService)
        {
            expensesService = _expensesService;
            // Note: I stopped with bug in connecting the user to the expenses, need to fix this bug first
            InitializeComponent();            
            PopulateExpensesGrid();
            ExpensesUser.DisplayMember = "UserName";
            ExpensesUser.ValueMember = "ID";
            ExpensesGrid.Columns["Id"].Visible = false;
            ExpensesGrid.Columns["UserName"].HeaderText = "اسم المستخدم";
            ExpensesGrid.Columns["Date"].HeaderText = "التاريخ";
            ExpensesGrid.Columns["Amount"].HeaderText = "المبلغ";
            ExpensesGrid.Columns["Description"].HeaderText = "الوصف";
        }
        private void PopulateExpensesGrid()
        {
            var expenses = expensesService.GetAllExpensesFromService();
            var expensesWithUserNames = expenses.Select(expense => new
            {
                expense.Id,
                expense.Description,
                expense.Amount,
                expense.Date,
                UserName = expense.User != null ? expense.User.Name : "غير معروف"
            }).ToList();
            ExpensesGrid.DataSource = expensesWithUserNames;
            
        }
        private void AddExpensesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ExpensesDescInput.Text) || ExpensesAmountInput.Value < 1)
            {
                MessageBox.Show("لا يمكن اضافة قيم فارغة", "فشل اضافة مصروفات", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Expense newExpenses = new Expense();
                newExpenses.Description = ExpensesDescInput.Text;
                newExpenses.Amount = ExpensesAmountInput.Value;
                if (ExpensesUser.SelectedItem is User selectedUser)
                {
                    newExpenses.UserId = selectedUser.Id;
                    newExpenses.User = expensesService.FindUUser(selectedUser.Id);
                }
                else
                {
                    MessageBox.Show("يرجى اختيار مستخدم صالح", "فشل اضافة مصروفات", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                newExpenses.Date = DateOnly.FromDateTime(ExpensesDateTime.Value);
                expensesService.AddExpensesFromService(newExpenses);
                PopulateExpensesGrid();
            }
        }
    }
}
