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
    public partial class UpdateDevice : BaseForm
    {
        private readonly DeviceService deviceService ;
        Device UpdatedDevice;
        public UpdateDevice(DeviceService _deviceService)
        {
            deviceService = _deviceService;
            InitializeComponent();
            ApplyGlobalStyles(this);
        }
        public UpdateDevice(Device device, DeviceService _deviceService)
        {
            deviceService = _deviceService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            UpdatedDevice = device;
            NewDeviceNameInput.Text = device.Name;
            NewDevicePriceInput.Value = device.HourlyRate;

        }

        private void UpdateDeviceBtn_Click(object sender, EventArgs e)
        {
            UpdatedDevice.Name = NewDeviceNameInput.Text;
            UpdatedDevice.HourlyRate = (byte)NewDevicePriceInput.Value;
            deviceService.UpdateDeviceFromService(UpdatedDevice);
            this.Close();
        }
    }
}
