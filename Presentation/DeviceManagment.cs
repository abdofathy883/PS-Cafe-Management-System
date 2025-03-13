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
