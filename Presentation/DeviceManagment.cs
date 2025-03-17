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

        public int PageSize = 10;
        public int CurrentPage = 1;
        private int TotalPages()
        {
            int totalUsers = deviceService.GetAllDevicesFromService().Count;
            return (int)Math.Ceiling((double)totalUsers / PageSize);
        }
        public DeviceManagment(DeviceService _deviceService)
        {
            deviceService = _deviceService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            DisplayDevicesTable();
        }
        private void DisplayDevicesTable()
        {
            DevicesTable.DataSource = null;

            int startIndex = (CurrentPage - 1) * PageSize;

            int RowHeight = DevicesTable.RowTemplate.Height;
            int HeaderHeight = DevicesTable.ColumnHeadersHeight;
            DevicesTable.Height = (PageSize * RowHeight) + HeaderHeight;

            if (CurrentPage > 1)
            {
                PreviousBtn.Enabled = true;
            }
            if (CurrentPage < TotalPages())
            {
                NextBtn.Enabled = true;

            }
            DevicesTable.DataSource = deviceService.GetAllDevicesFromService()
                .Select(d => new { d.Id, d.Name, d.Type, d.HourlyRate, d.HourlyRateForMulti, d.status })
                .Skip(startIndex)
                .Take(PageSize)
                .ToList();
            DevicesTable.Columns["ID"].Visible = false;
            DevicesTable.Columns["Name"].HeaderText = "الاسم";
            DevicesTable.Columns["Type"].HeaderText = "النوع";
            DevicesTable.Columns["HourlyRate"].HeaderText = "الساعة سنجل";
            DevicesTable.Columns["HourlyRateForMulti"].HeaderText = " الساعة مالتي";
            DevicesTable.Columns["status"].HeaderText = "نشاط الجهاز";
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
                device.HourlyRateForMulti = HourlyRateMulti.Value;

                //Check for already existing device
                if (deviceService.IsDeviceNameIsUsed(device.Name))
                {
                    MessageBox.Show("هذا الجهاز موجود بالفعل", "فشل اضافة جهاز", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                deviceService.AddDeviceFromService(device);

                DisplayDevicesTable();

            }
        }
        private void DevicesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColumnName = DevicesTable.Columns[e.ColumnIndex].Name;
            if (ColumnName == "UpdateCellButton")
            {

                var Id = Convert.ToInt32(DevicesTable.Rows[e.RowIndex].Cells["ID"].Value);
                UpdateDevice updateDevice = new UpdateDevice(Id, deviceService);
                updateDevice.ShowDialog();
                DisplayDevicesTable();
            }
            else if (ColumnName == "DeleteCellButton")
            {
                DialogResult DeleteDialog = MessageBox.Show("تأكيد حذف الجهاز! سيتم حذف الجهاز نهائيا واي بيانات متلعقة به", "حذف جهاز", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DeleteDialog == DialogResult.OK)
                {
                    Device device = new()
                    {
                        Id = Convert.ToInt32(DevicesTable.Rows[e.RowIndex].Cells["ID"].Value),
                        Name = DevicesTable.Rows[e.RowIndex].Cells["Name"].Value?.ToString() ?? "غير محدد",
                        Type = (string)DevicesTable.Rows[e.RowIndex].Cells["Type"].Value,
                        HourlyRate = Convert.ToByte(DevicesTable.Rows[e.RowIndex].Cells["HourlyRate"].Value),
                        HourlyRateForMulti = Convert.ToByte(DevicesTable.Rows[e.RowIndex].Cells["HourlyRateForMulti"].Value)
                    };
                    deviceService.RemoveDeviceFromService(device);
                    DisplayDevicesTable();
                }
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages())
            {
                CurrentPage++;
                DisplayDevicesTable();
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                DisplayDevicesTable();
            }
        }
    }
}
