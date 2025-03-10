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
    public partial class UpdateUser : BaseForm
    {
        User UpdatedUser = new User();
        UserService userService = new UserService();
        public UpdateUser()
        {
            InitializeComponent();
        }
        public UpdateUser(User user)
        {
            InitializeComponent();
            UpdatedUser = user;
            NewUserNameInput.Text = UpdatedUser.Name;
            NewUserPassInput.Text = UpdatedUser.Password;
            UserTypeCombo.SelectedItem = UpdatedUser.Role;
        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            UpdatedUser.Name = NewUserNameInput.Text;
            UpdatedUser.Password = NewUserPassInput.Text;
            UpdatedUser.Role = (string)UserTypeCombo.SelectedItem;
            userService.UpdateUserFromService(UpdatedUser);
        }
    }
}
