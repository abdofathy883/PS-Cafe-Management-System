using Microsoft.Extensions.DependencyInjection;
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
        private readonly IServiceProvider _serviceProvider;
        public Home(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        public void ShowFormInPanel<T>() where T : Form
        {
            MainContainer.Controls.Clear();
            Form form = _serviceProvider.GetRequiredService<T>();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            form.AutoSize = false;
            form.AutoScaleMode = AutoScaleMode.None;
            form.StartPosition = FormStartPosition.Manual;
            MainContainer.Dock = DockStyle.Fill;
            MainContainer.AutoScroll = false;
            MainContainer.Padding = new Padding(0);
            MainContainer.Margin = new Padding(0);
            form.Load += (s, e) =>
            {
                int x = (MainContainer.Width - form.Width) / 2;
                int y = (MainContainer.Height - form.Height) / 2;
                form.Location = new Point(Math.Max(0, x), Math.Max(0, y));
                form.Size = new Size(Math.Min(MainContainer.Width, form.Width),
                                     Math.Min(MainContainer.Height, form.Height));
            };
            MainContainer.Controls.Add(form);
            form.Show();
        }
        private void UserManagementBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<UserManagement>();
        }
        private void DeviceManagementBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<DeviceManagment>();
        }
        private void UserManagementBtn_DragEnter(object sender, DragEventArgs e)
        {
            ShowFormInPanel<UserManagement>();
        }
        private void CafetriaBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<Cafetria>();
        }
        private void ExpensesBtn_Click(object sender, EventArgs e)
        {
            ShowFormInPanel<ExpensesForm>();
        }
        private void Home_Load(object sender, EventArgs e)
        {
        }
    }
}
