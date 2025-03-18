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
        private readonly UserService userService;
        public int PageSize = 10;
        public int CurrentPage = 1;
        private int TotalPages()
        {
            int totalUsers = expensesService.GetAllExpensesFromService().Count;
            return (int)Math.Ceiling((double)totalUsers / PageSize);
        }
        public ExpensesForm(ExpensesService _expensesService, UserService _userService)
        {
            expensesService = _expensesService;
            userService = _userService;
            // Note: I stopped with bug in connecting the user to the expenses, need to fix this bug first
            InitializeComponent();
            ApplyGlobalStyles(this);
            PopulateExpensesGrid();
            ExpensesUser.DataSource = userService.GetAllUsersFromService();
            ExpensesUser.DisplayMember = "Name";
            ExpensesUser.ValueMember = "Id";
        }
        private void PopulateExpensesGrid()
        {
            ExpensesGrid.DataSource = null;

            int startIndex = (CurrentPage - 1) * PageSize;
            var PageData = expensesService.GetAllExpensesFromService()
                .Select(expense => new
                {
                    expense.Id,
                    expense.Description,
                    expense.Amount,
                    expense.Date,
                    UserName = expense.User != null ? expense.User.Name : "غير معروف"
                })
                .Skip(startIndex)
                .Take(PageSize)
                .ToList();

            ExpensesGrid.DataSource = PageData;

            int RowHeight = ExpensesGrid.RowTemplate.Height;
            int HeaderHeight = ExpensesGrid.ColumnHeadersHeight;
            ExpensesGrid.Height = (PageData.Count * RowHeight) + HeaderHeight;

            ExpensesGrid.Columns["Id"].Visible = false;
            ExpensesGrid.Columns["UserName"].HeaderText = "اسم المستخدم";
            ExpensesGrid.Columns["Date"].HeaderText = "التاريخ";
            ExpensesGrid.Columns["Amount"].HeaderText = "المبلغ";
            ExpensesGrid.Columns["Description"].HeaderText = "الوصف";

            if (CurrentPage > 1)
            {
                previousBtn.Enabled = true;
            }
            if (CurrentPage < TotalPages())
            {
                NextBtn.Enabled = true;

            }
            
            
        }
        private void AddExpensesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ExpensesDescInput.Text) || ExpensesAmountInput.Value < 1)
            {
                MessageBox.Show("لا يمكن اضافة قيم فارغة", "فشل اضافة مصروفات", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            //else if (ExpensesDateTime.Value > DateTime.Now)
            //{
            //    MessageBox.Show("لا يمكن اختيار تاريخ مسبق", "فشل اضافة مصروفات", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //    return;
            //}
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

        private void ExpensesForm_Load(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages())
            {
                CurrentPage++;
                PopulateExpensesGrid();
            }
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                PopulateExpensesGrid();
            }
        }
    }
}
