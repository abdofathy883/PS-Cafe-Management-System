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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PlayStation.Presentation
{
    public partial class AllDevices: BaseForm
    {
        static FlowLayoutPanel? layoutPanel;
        private  readonly CafeService cafeService;
        private  readonly SessionService sessionService;
        private readonly DeviceService deviceService;
        private readonly OrderDetailsService orderDetailsService;
        public AllDevices(CafeService _cafeService,SessionService _sessionService, DeviceService _deviceService, OrderDetailsService _orderDetailsService)
        {
            cafeService = _cafeService;
            sessionService = _sessionService;
            deviceService = _deviceService;
            orderDetailsService=_orderDetailsService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            layoutPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.RightToLeft
            };
            this.Controls.Add(layoutPanel);
            foreach(var device in deviceService.GetAllDevicesFromService())
            {
                AddDeviceToLayout(CreatePanalForDevice(device));
            }
        }
        
        public static void AddDeviceToLayout(Panel DevicePanel)
        {
            layoutPanel.Controls.Add(DevicePanel);
            layoutPanel.Refresh();
        }
        
        public Panel CreatePanalForDevice(Device device)
        {
            //Create a new panel for the new device and add it to the All Devices Form
            Panel DevicePanel = new ()
            {
                Size = new Size(250, 310),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.Black
            };

            Label DeviceName = new ()
            {
                Text = device.Name,
                Location = new Point(65, 10),
                Width = 120,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold)
            };
            PictureBox DeviceImage = new()
            {
                Size = new Size(225, 180),
                Location = new Point(12, 45),
                Image = Image.FromFile("DeviceImage.jpg"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label DeviceStatus = new ()
            {
                Text = device.status.ToString(),
                Location = new Point(65, 230),
                Width = 120,
                TextAlign = ContentAlignment.MiddleCenter, 
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold)
            };
            Button ManageBtn = new ()
            {
                Text = "ادارة",
                Width = DevicePanel.Width - 20,
                Location = new Point(10, 265),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#DDA853"),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Height = 30
            };
            ManageBtn.Click += (s, e) =>
            {
                SingleDevice singleDevice = new SingleDevice(device.Id,cafeService,sessionService,deviceService,orderDetailsService);
                singleDevice.ShowDialog();
                DeviceStatus.Text = deviceService.GetDeviceByIdFromService(device.Id).status.ToString();
            };

            //Add the controls to the panel
            DevicePanel.Controls.Add(DeviceName);
            DevicePanel.Controls.Add(DeviceImage);
            DevicePanel.Controls.Add(DeviceStatus);
            DevicePanel.Controls.Add(ManageBtn);


            return DevicePanel;
        }
    }
}
