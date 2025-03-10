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
    public partial class LogIn : BaseForm
    {
        private readonly UserService userService ;
        public LogIn(UserService _userService)
        {
            userService = _userService;
            InitializeComponent();
        }
        /// <summary>
        /// Click Event Of Log In Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Show MessageBox in Case Empty Input and Return
        /// Show MessageBox in Case Wrong User and Return
        /// Redirect To Home Form In Case Valid User
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameInput.Text) || string.IsNullOrWhiteSpace(PasswordInput.Text))
            {
                MessageBox.Show("الاسم او الرقم السري خطا - برجاء ادخال بيانات صحيحة", "فشل تسجيل الدخول", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                User user = new User();
                user.Id = int.Parse(PasswordInput.Text);
                user.Name = NameInput.Text;
                var isExisted =userService.GetAllUsersFromService().Contains(user);  
                if (isExisted)
                {
                    //Home home = new Home();
                    //home.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("لا يوجد مستخدم بهذه البيانات - برجاء مراجعة الادمن", "مستخدم خاطئ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
