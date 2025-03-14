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
        private readonly UserService userService;
        private readonly LoginSessionService loginSessionService;
        private readonly Home _home;
        public LogIn(UserService _userService, Home home, LoginSessionService _loginSessionService)
        {
            userService = _userService;
            _home = home;
            InitializeComponent();
            ApplyGlobalStyles(this);
            loginSessionService = _loginSessionService;
            var session = loginSessionService.GetLastLoginSessionFromService();
            if(session != null && !session.IsLoggedOut)
            {
                this.Hide();
                _home.ShowDialog();
                session.LogoutTime = DateTime.Now;
                session.IsLoggedOut = true;
                loginSessionService.UpdateLoginSessionFromService(session);
                this.Show();
            }
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
                User? user = userService.GetUserByUserFromService(NameInput.Text);
                if (user != null)
                {
                    if (user.Password != PasswordInput.Text)
                    {
                        MessageBox.Show("الرقم السري خطا - برجاء ادخال بيانات صحيحة", "فشل تسجيل الدخول", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    var session = new LoginSession()
                    {
                        UserId = user.Id,
                        LoginTime = DateTime.Now
                    };
                    loginSessionService.AddLoginSessionFromService(session);
                    this.Hide();
                    _home.ShowDialog();

                    session.LogoutTime = DateTime.Now;
                    session.IsLoggedOut = true;
                    loginSessionService.UpdateLoginSessionFromService(session);
                    this.Show();
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
