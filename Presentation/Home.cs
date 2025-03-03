using PlayStation.Application.Services;
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
    public partial class Home : BaseForm
    {
        public Home()
        {
            InitializeComponent();

        }
        public void ShowFormInPanel(Form form)
        {
            MainContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            form.Load += (s, e) =>
            {
                int x = (MainContainer.Width - form.Width) / 2;
                int y = (MainContainer.Height - form.Height) / 2;
                form.Location = new Point(x, y);
            };
            MainContainer.Controls.Add(form);
            form.Show();
        }
        private void UserManagementBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new UserManagement());
        }
        private void DeviceManagementBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new DeviceManagment());
        }
        private void UserManagementBtn_DragEnter(object sender, DragEventArgs e)
        {
            ShowFormInPanel(new UserManagement());
        }
        private void CafetriaBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new Cafetria());
        }
        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ExpensesForm());
        }
        private void Home_Load(object sender, EventArgs e)
        {
        }
    }
}
