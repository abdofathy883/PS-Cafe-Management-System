﻿using PlayStation.Application.Services;
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
        UserService UserService = new UserService();
        public UserManagement()
        {
            InitializeComponent();
            UsersTableGrid.DataSource = UserService.GetAllUsersFromService();
            UsersTableGrid.Columns["ID"].Visible = false;
            UsersTableGrid.Columns["Password"].Visible = false;
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
                
                UserService.AddUserFromService(user);
                UsersTableGrid.DataSource = null;
                UsersTableGrid.DataSource = UserService.GetAllUsersFromService();
            }
        }
        private void UsersTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColumnName = UsersTableGrid.Columns[e.ColumnIndex].Name;
            if (ColumnName == "UpdateUser")
            {
                User UpdatedUser = new()
                {
                    Id = Convert.ToInt32(UsersTableGrid.Rows[e.RowIndex].Cells["ID"].Value),
                    Name = UsersTableGrid.Rows[e.RowIndex].Cells["UserName"].Value?.ToString() ?? string.Empty,
                    Password = UsersTableGrid.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty,
                    Role = (string)UsersTableGrid.Rows[e.RowIndex].Cells["Role"].Value
                };
                UpdateUser updatedUser = new(UpdatedUser);
                updatedUser.ShowDialog();
            }
            else if (ColumnName == "DeleteUser")
            {
                User UpdatedUser = new()
                {
                    Id = Convert.ToInt32(UsersTableGrid.Rows[e.RowIndex].Cells["ID"].Value),
                    Name = UsersTableGrid.Rows[e.RowIndex].Cells["UserName"].Value?.ToString() ?? string.Empty,
                    Password = UsersTableGrid.Rows[e.RowIndex].Cells["Password"].Value?.ToString() ?? string.Empty,
                    Role = (string)UsersTableGrid.Rows[e.RowIndex].Cells["Role"].Value
                };
                UserService.DeleteUserFromService(UpdatedUser);
                UsersTableGrid.Refresh();
            }
        }
    }
}
