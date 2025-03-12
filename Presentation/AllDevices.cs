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
    public partial class AllDevices: BaseForm
    {
        FlowLayoutPanel layoutPanel;
        public AllDevices()
        {
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
        }
        
        public void AddDeviceToLayout(Panel DevicePanel)
        {
            layoutPanel.Controls.Add(DevicePanel);
            layoutPanel.Refresh();
        }
    }
}
