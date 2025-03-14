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
    public partial class SingleDevice : BaseForm
    {
        private readonly CafeService CafeService;
        private readonly SessionService sessionService;
        private readonly DeviceService deviceService;
        Device CurrentDevice;
        Session CurrentSession;
        AllDevices AllDevices;
        //private System.Timers.Timer timer;
        private int elapsedSeconds;
        public SingleDevice(int _CurrentDeviceId, CafeService _CafeService, SessionService _sessionService, DeviceService _deviceService, AllDevices _allDevices)
        {
            InitializeComponent();
            ApplyGlobalStyles(this);

            CafeService = _CafeService;
            sessionService = _sessionService;
            deviceService = _deviceService;
            AllDevices = _allDevices;

            CurrentDevice = deviceService.GetDeviceByIdFromService(_CurrentDeviceId);

            ItemsCombo.DataSource = CafeService.GetCafeItemsFromService();
            ItemsCombo.DisplayMember = "Name";
            ItemsCombo.ValueMember = "Id";
            if (CurrentDevice.status == DevaisStatus.NotAvailable)
            {
                CurrentSession = CurrentDevice.Sessions.First(s => s.Status == "Active");
            }
            DeviceNameLbl.Text = CurrentDevice.Name;

            //timer = new System.Timers.Timer();
            //timer.Interval = 1000;
            //timer.Tick +=
        }
        //public void Timer_Tick(object sender, EventArgs e)
        //{
        //    Seconds++;
        //    TimerLbl.Text = $"{Seconds}";
        //}

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (CurrentSession == null)
            {
                MessageBox.Show("يرجي بدا الجلسه قبل اضافة منتج", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ItemsCounter.Value <= 0)
            {
                MessageBox.Show("يرجى اختيار عدد الوحدات المستخدمة من هذا المنتج", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                //var item = CafeService.GetItemByID((int)ItemsCombo.SelectedValue);
                var selectedValue = ItemsCombo.SelectedValue;
                if (selectedValue == null)
                {
                    MessageBox.Show("يرجى اختيار منتج صالح", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var item = CafeService.GetItemByID((int)selectedValue);
                if (item.Stock < ItemsCounter.Value)
                {
                    MessageBox.Show("الكمية المتاحة لهذا المنتج اقل من الكمية المطلوبة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                var Itemsprice = CafeService.GetCafeItemByIdFromService((int)ItemsCombo.SelectedValue).Price;
                OrderDetail orderDetail = new OrderDetail()
                {
                    Id = 0,
                    ItemId = item.Id,
                    Quantity = (int)ItemsCounter.Value,
                    UnitPrice = Itemsprice,
                    SessionId = CurrentSession.Id
                };
                CurrentSession.TotalCost += (Itemsprice * (int)ItemsCounter.Value);
                CurrentSession.OrderDetails.Add(orderDetail);
                sessionService.UpdateSessionFromService(CurrentSession);
                item.Stock -= (byte)ItemsCounter.Value;
                CafeService.UpdateCafeItemFromService(item);
                var CurrentOrderList = CurrentSession.OrderDetails.Select(o => new { o.Item.Name, o.Quantity, o.TotalPrice }).ToList();
                OrderGrid.DataSource = null;
                OrderGrid.DataSource = CurrentOrderList;
            }
            TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SingleDevice_Load(object sender, EventArgs e)
        {

        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void SessionToggle()
        //{
        //    if (dateTimePicker1.ShowCheckBox == true)
        //    {
        //        StartBtn.Enabled = false;
        //        StartBtn.Hide = false;
        //    }
        //}
        private void StartBtn_Click(object sender, EventArgs e)
        {
            elapsedSeconds = 0;
            TimerLbl.Text = "00:00:00";
            timer.Start();
            CurrentSession = new Session()
            {
                Id = 0,
                DeviceId = CurrentDevice.Id,
                StartTime = DateTime.Now,
                EndTime = null,
                Status = "Active",
                TotalCost = 0,
                Duration = 0,
                OrderDetails = new List<OrderDetail>()
            };
            CurrentDevice.status = DevaisStatus.NotAvailable;
            sessionService.AddSessionFromService(CurrentSession);
            deviceService.UpdateDeviceFromService(CurrentDevice);
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (CurrentSession == null)
            {
                MessageBox.Show("يرجي بدا الجلسه قبل اضافة منتج", "فشل في انهاء الجلسه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CurrentSession.EndTime = DateTime.Now;
            CurrentSession.Status = "Closed";
            if (CurrentSession.EndTime.HasValue)
            {
                CurrentSession.Duration = (decimal)(CurrentSession.EndTime.Value - CurrentSession.StartTime).TotalMinutes;
            }
            CurrentSession.TotalCost += Math.Round(((CurrentSession.Duration / 60) * CurrentDevice.HourlyRate), 2);
            sessionService.UpdateSessionFromService(CurrentSession);
            TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();

            CurrentDevice.status = DevaisStatus.Available;
            deviceService.UpdateDeviceFromService(CurrentDevice);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SingleDevice_FormClosing(object sender, FormClosingEventArgs e)
        {
            //AllDevices.Refresh();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            StartBtn.Enabled = !dateTimePicker1.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Seconds++;
            //TimerLbl.Text = $"{Seconds}";


            elapsedSeconds++;
            int hours = elapsedSeconds / 3600;
            int minutes = (elapsedSeconds % 3600) / 60;
            int seconds = elapsedSeconds % 60;
            TimerLbl.Text = $"{hours}:{minutes}:{seconds}";
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            EndBtn.Enabled = !dateTimePickerEnd.Checked;
        }
    }
}
