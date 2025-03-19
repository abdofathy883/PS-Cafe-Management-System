using PlayStation.Application.Services;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayStation.Presentation
{
    public partial class UserManagement : BaseForm
    {
        private readonly UserService userService;
        //
        public int PageSize = 10;
        public int CurrentPage = 1;
        private int TotalPages()
        {
            int totalUsers = userService.GetAllUsersFromService().Count;
            return (int)Math.Ceiling((double)totalUsers / PageSize);
        }

        public UserManagement(UserService _userService)
        {
            userService = _userService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            DisplayUsersTableGrid();
        }
        private void DisplayUsersTableGrid()
        {
            UsersTableGrid.DataSource = null;

            int startIndex = (CurrentPage - 1) * PageSize;
            var PageData = userService.GetAllUsersFromService().Where(u => u.IsDeleted = true).Skip(startIndex).Take(PageSize).ToList();
            UsersTableGrid.DataSource = PageData;

            int RowHeight = UsersTableGrid.RowTemplate.Height;
            int HeaderHeight = UsersTableGrid.ColumnHeadersHeight;
            UsersTableGrid.Height = (PageSize * RowHeight) + HeaderHeight;

            if (CurrentPage > 1)
            {
                PreviousBtn.Enabled = true;
            }
            if (CurrentPage < TotalPages())
            {
                NextBtn.Enabled = true;
                
            }
            //PreviousBtn.Enabled = CurrentPage > 1;
            //NextBtn.Enabled = CurrentPage < TotalPages();

            UsersTableGrid.Columns["Id"].Visible = false;
            UsersTableGrid.Columns["Password"].Visible = false;
            UsersTableGrid.Columns["IsDeleted"].Visible = false;
            UsersTableGrid.Columns["LoginSession"].Visible = false;
            UsersTableGrid.Columns["Expenses"].Visible = false;
            UsersTableGrid.Columns["Session"].Visible = false;
            UsersTableGrid.Columns["Name"].HeaderText = "الاسم";
            UsersTableGrid.Columns["Role"].HeaderText = "الدور";
            UsersTableGrid.Columns["TotalExpense"].HeaderText = "مجموع المصاريف";
        }
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameInput.Text) || string.IsNullOrWhiteSpace(PasswordInput.Text))
            {
                MessageBox.Show("لا يمكن اضافة مستخدم بدون بيانات", "فشل اضافة مستخدم", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                User user = new User()
                {
                    Name = NameInput.Text,
                    Password = PasswordInput.Text,
                    Role = (string)RolesCombo.SelectedItem ?? "موظف"
                };

                //Check for already existing user
                if (userService.IsUsereNameIsUsed(user.Name))
                {
                    MessageBox.Show("هذا الحساب موجود بالفعل", "فشل اضافة حساب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                userService.AddUserFromService(user);
                DisplayUsersTableGrid();
            }
        }
        private void UsersTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColumnName = UsersTableGrid.Columns[e.ColumnIndex].Name;
            if (ColumnName == "UpdateUser")
            {
                var Id = Convert.ToInt32(UsersTableGrid.Rows[e.RowIndex].Cells["ID"].Value);

                UpdateUser updatedUser = new UpdateUser(Id, userService);
                updatedUser.ShowDialog();
                DisplayUsersTableGrid();
            }
            else if (ColumnName == "DeleteUser")
            {
                DialogResult DeleteDialog = MessageBox.Show("تأكيد حذف الحساب! سيتم حذف الحساب نهائيا واي بيانات متلعقة به", "حذف حساب", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DeleteDialog == DialogResult.OK)
                {
                    User UpdatedUser = new()
                    {
                        Id = Convert.ToInt32(UsersTableGrid.Rows[e.RowIndex].Cells["Id"].Value),
                        Name = UsersTableGrid.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? string.Empty,
                        Password = UsersTableGrid.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty,
                        Role = (string)UsersTableGrid.Rows[e.RowIndex].Cells["Role"].Value
                    };
                    userService.DeleteUserFromService(UpdatedUser);
                    DisplayUsersTableGrid();
                }
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages())
            {
                CurrentPage++;
                DisplayUsersTableGrid();
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                DisplayUsersTableGrid();
            }
        }
    }
}
