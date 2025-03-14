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
    public partial class UpdateDevice : BaseForm
    {
        private readonly DeviceService deviceService;
        Device UpdatedDevice;
        public UpdateDevice(int deviceId, DeviceService _deviceService)
        {
            deviceService = _deviceService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            UpdatedDevice = deviceService.GetDeviceByIdFromService(deviceId);
            NewDeviceNameInput.Text = UpdatedDevice.Name;
            NewDevicePriceInput.Value = UpdatedDevice.HourlyRate;

        }

        private void UpdateDeviceBtn_Click(object sender, EventArgs e)
        {
            if (UpdatedDevice.Name != NewDeviceNameInput.Text && deviceService.IsDeviceNameIsUsed(NewDeviceNameInput.Text))
            {
                MessageBox.Show("هذا الجهاز موجود بالفعل", "فشل اضافة جهاز", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdatedDevice.Name = NewDeviceNameInput.Text;
            UpdatedDevice.HourlyRate = NewDevicePriceInput.Value;
            deviceService.UpdateDeviceFromService(UpdatedDevice);
            this.Close();
        }

    }
}
