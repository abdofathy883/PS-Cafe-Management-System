using PlayStation.Application.Services;
using PlayStation.Infrastructure.Repos;
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
    public partial class DeviceManagment : BaseForm
    {
        private readonly DeviceService deviceService;
        private AllDevices AllDevices;
        public DeviceManagment(DeviceService _deviceService)
        {
            deviceService = _deviceService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            DevicesTable.DataSource = deviceService.GetAllDevicesFromService();
            DevicesTable.Columns["ID"].Visible = false;
            DevicesTable.Columns["Name"].HeaderText = "الاسم";
            DevicesTable.Columns["Type"].HeaderText = "النوع";
            DevicesTable.Columns["HourlyRate"].HeaderText = "سعر الساعة";
            DevicesTable.Columns["Sessions"].HeaderText = "نشاط الجهاز";
            DevicesTable.Columns["Status"].Visible = false;
            DevicesTable.Columns["IsDeleted"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DeNameInput.Text))
            {
                MessageBox.Show("برجاء ادخال اسم الجهاز", "فشل ادخال جهاز جديد", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Device device = new Device();
                device.Name = DeNameInput.Text;
                device.Type = (string)DeTypeCombo.SelectedItem;
                device.HourlyRate = (byte)HourlyRateInput.Value;
                deviceService.AddDeviceFromService(device);
                DevicesTable.Refresh();

                //Create a new panel for the new device and add it to the All Devices Form
                Panel DevicePanel = new Panel()
                {
                    Size = new Size(350, 200),
                    //Will be setted dynamically
                    //Location = new Point(),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                Label DeviceName = new Label()
                {
                    Text = device.Name,
                    Location = new Point(10, 10)
                };
                PictureBox DeviceImage = new PictureBox()
                {
                    Size = new Size(100, 100),
                    Location = new Point(10, 40),
                    Image = Image.FromFile("C:\\Users\\iTi\\Documents\\GitHub\\PS-Cafe-Management-System\\DeviceImage.jpg"), // image path
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                Label DeviceStatus = new Label()
                {
                    Text = device.status.ToString(),
                    Location = new Point(120, 40)
                };
                Button ManageBtn = new Button()
                {
                    Text = "ادارة",
                    Location = new Point(120, 80)
                };
                ManageBtn.Click += (s, e) =>
                {
                    SingleDevice singleDevice = new SingleDevice(device);
                    singleDevice.Show();
                };

                //Add the controls to the panel
                DevicePanel.Controls.Add(DeviceName);
                DevicePanel.Controls.Add(DeviceImage);
                DevicePanel.Controls.Add(DeviceStatus);
                DevicePanel.Controls.Add(ManageBtn);

                if (AllDevices == null || AllDevices.IsDisposed)
                {
                    AllDevices = new AllDevices();
                    AllDevices.Show();
                }
                AllDevices.AddDeviceToLayout(DevicePanel);
            }
        }
        private void DevicesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColumnName = DevicesTable.Columns[e.ColumnIndex].Name;
            if (ColumnName == "UpdateCellButton")
            {
                Device device = new()
                {
                    Id = Convert.ToInt32(DevicesTable.Rows[e.RowIndex].Cells["ID"].Value),
                    Name = DevicesTable.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? "غير محدد",
                    Type = (string)DevicesTable.Rows[e.RowIndex].Cells["Type"].Value,
                    HourlyRate = Convert.ToByte(DevicesTable.Rows[e.RowIndex].Cells["HourlyRate"].Value)
                };
                UpdateDevice updateDevice = new UpdateDevice(device,deviceService);
                updateDevice.ShowDialog();
            }
            else if(ColumnName == "DeleteCellButton")
            {
                Device device = new()
                {
                    Id = Convert.ToInt32(DevicesTable.Rows[e.RowIndex].Cells["ID"].Value),
                    Name = DevicesTable.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? "غير محدد",
                    Type = (string)DevicesTable.Rows[e.RowIndex].Cells["Type"].Value,
                    HourlyRate = Convert.ToByte(DevicesTable.Rows[e.RowIndex].Cells["HourlyRate"].Value)
                };
                deviceService.RemoveDeviceFromService(device);
                DevicesTable.DataSource = null;
                DevicesTable.DataSource = deviceService.GetAllDevicesFromService();
            }

        }
    }
}
