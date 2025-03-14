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
    public partial class UpdateUser : BaseForm
    {
        private User UpdatedUser ;
        private readonly UserService userService ;
        public UpdateUser(int userId , UserService _userService)
        {
            userService = _userService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            UpdatedUser = userService.GetUserByIdFromService(userId);
            NewUserNameInput.Text = UpdatedUser.Name;
            NewUserPassInput.Text = UpdatedUser.Password;
            UserTypeCombo.SelectedItem = UpdatedUser.Role;
        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            if (UpdatedUser.Name != NewUserNameInput.Text && userService.IsUsereNameIsUsed(NewUserNameInput.Text))
            {
                MessageBox.Show("هذا الحساب موجود بالفعل", "فشل اضافة حساب", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdatedUser.Name = NewUserNameInput.Text;
            UpdatedUser.Password = NewUserPassInput.Text;
            UpdatedUser.Role = UserTypeCombo.SelectedItem as string ?? string.Empty;
            userService.UpdateUserFromService(UpdatedUser);
        }
    }
}
