using PlayStation.Application.Services;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayStation.Presentation
{
    public partial class UserManagement : BaseForm
    {
        private readonly UserService userService;
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
            UsersTableGrid.DataSource = userService.GetUsersWithDataFromService();
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
                if (userService.IsUsereNameIsUsed( user.Name))
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
            }
            else if (ColumnName == "DeleteUser")
            {
                DialogResult DeleteDialog = MessageBox.Show("تأكيد حذف الحساب! سيتم حذف الحساب نهائيا واي بيانات متلعقة به", "حذف حساب", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DeleteDialog == DialogResult.OK)
                {
                    User UpdatedUser = new()
                    {
                        Id = Convert.ToInt32(UsersTableGrid.Rows[e.RowIndex].Cells["ID"].Value),
                        Name = UsersTableGrid.Rows[e.RowIndex].Cells["UserName"].Value?.ToString() ?? string.Empty,
                        Password = UsersTableGrid.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty,
                        Role = (string)UsersTableGrid.Rows[e.RowIndex].Cells["Role"].Value
                    };
                    userService.DeleteUserFromService(UpdatedUser);
                    DisplayUsersTableGrid();
                }
            }
        }
    }
}
