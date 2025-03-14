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
        static FlowLayoutPanel layoutPanel;
        private  readonly CafeService cafeService;
        private  readonly SessionService sessionService;
        private readonly DeviceService deviceService;
        public AllDevices(CafeService _cafeService,SessionService _sessionService, DeviceService _deviceService)
        {
            cafeService = _cafeService;
            sessionService = _sessionService;
            deviceService = _deviceService;
            InitializeComponent();
            ApplyGlobalStyles(this);
            layoutPanel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight
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
            Panel DevicePanel = new Panel()
            {
                Size = new Size(250, 300),
                BorderStyle = BorderStyle.FixedSingle,
                //BackColor = Color.White,
                ForeColor = Color.Black
            };

            Label DeviceName = new Label()
            {
                Text = device.Name,
                Location = new Point(65, 10),
                Width = 120,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold)
            };
            PictureBox DeviceImage = new PictureBox()
            {
                Size = new Size(225, 180),
                Location = new Point(12, 45),
                Image = Image.FromFile("DeviceImage.jpg"), // image path
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Label DeviceStatus = new Label()
            {
                Text = device.status.ToString(),
                Location = new Point(65, 230),
                Width = 120,
                TextAlign = ContentAlignment.MiddleCenter, 
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold)
            };
            Button ManageBtn = new Button()
            {
                Text = "ادارة",
                Width = DevicePanel.Width - 20,
                Location = new Point(10, 260),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = ColorTranslator.FromHtml("#205781"),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Height = 30
            };
            ManageBtn.Click += (s, e) =>
            {
                SingleDevice singleDevice = new SingleDevice(device.Id,cafeService,sessionService,deviceService);
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
