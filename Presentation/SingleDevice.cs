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
        private readonly CafeService cafeService;
        private readonly SessionService sessionService;
        private readonly DeviceService deviceService;
        private readonly OrderDetailsService orderDetailsService;
        Device CurrentDevice;
        Session CurrentSession;
        private int elapsedSeconds;
        public SingleDevice(int _CurrentDeviceId, CafeService _CafeService, SessionService _sessionService, DeviceService _deviceService, OrderDetailsService _orderDetailsService)
        {
            InitializeComponent();
            ApplyGlobalStyles(this);

            cafeService = _CafeService;
            sessionService = _sessionService;
            deviceService = _deviceService;
            orderDetailsService = _orderDetailsService;

            CurrentDevice = deviceService.GetDeviceByIdFromService(_CurrentDeviceId);

            ItemsCombo.DataSource = cafeService.GetCafeItemsFromService();
            ItemsCombo.DisplayMember = "Name";
            ItemsCombo.ValueMember = "Id";
            if (CurrentDevice.status == DevaisStatus.مشغول)
            {
                CurrentSession = CurrentDevice.Sessions.First(s => s.Status == "Active");
                elapsedSeconds = ((int)(DateTime.Now - CurrentSession.StartTime).TotalSeconds);
                timer.Start();
                TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();
                StartBtn.Enabled = false;
            }
            else
            {
                EndBtn.Enabled = false;
            }
            DeviceNameLbl.Text = CurrentDevice.Name;
            PopulateOrderGrid();

        }
        private void PopulateOrderGrid()
        {
            if (CurrentSession != null)
            {
                var CurrentOrderList = CurrentSession.OrderDetails.Where(d => d.IsDeleted == false)
                    .Select(o => new { o.Id,o.Item.Name, o.Quantity, o.TotalPrice })
                    .ToList();
                //CurrentOrderList.columns
                OrderGrid.DataSource = null;
                OrderGrid.DataSource = CurrentOrderList;

                OrderGrid.Columns["Id"].Visible=false;
                OrderGrid.Columns["Name"].HeaderText = "المنتج";
                OrderGrid.Columns["Quantity"].HeaderText = "العدد";
                OrderGrid.Columns["TotalPrice"].HeaderText = "المجموع";

            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (CurrentSession == null)
            {
                MessageBox.Show("يرجي بدا الجلسه قبل اضافة منتج", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                //AddItemBtn.Enabled = false;
            }
            if (ItemsCounter.Value <= 0)
            {
                MessageBox.Show("يرجى اختيار عدد الوحدات المستخدمة من هذا المنتج", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                //AddItemBtn.Enabled = false;
            }
            else
            {

                var selectedValue = ItemsCombo.SelectedValue;
                if (selectedValue == null)
                {
                    MessageBox.Show("يرجى اختيار منتج صالح", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var item = cafeService.GetItemByID((int)selectedValue);
                if (item.Stock < ItemsCounter.Value)
                {
                    MessageBox.Show("الكمية المتاحة لهذا المنتج اقل من الكمية المطلوبة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                var Itemsprice = cafeService.GetCafeItemByIdFromService((int)ItemsCombo.SelectedValue).Price;
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
                item.Stock -= ItemsCounter.Value;
                cafeService.UpdateCafeItemFromService(item);
                PopulateOrderGrid();


            }
            TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!MultiRadio.Checked && !SingleRadio.Checked)
            {
                MessageBox.Show("يرجى اختيار نوع اللعب قبل البدء", "فشل بدء اللعب", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DateTime parsedTime;

            // Force DateTimePicker to take the current time if input is empty or invalid
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text) || !DateTime.TryParse(dateTimePicker1.Text, out parsedTime))
            {
                parsedTime = DateTime.Now;
                dateTimePicker1.Value = parsedTime;
            }

            // Set the DateTimePicker value to the valid parsed time
            dateTimePicker1.Value = parsedTime;


            elapsedSeconds = 0;
            TimerLbl.Text = "00:00:00";
            timer.Start();
            CurrentSession = new Session()
            {
                Id = 0,
                DeviceId = CurrentDevice.Id,
                StartTime = dateTimePicker1.Value, //DateTime.Now,
                EndTime = null,
                Status = "Active",
                TotalCost = 0,
                Duration = 0,
                OrderDetails = new List<OrderDetail>()
            };
            if (MultiRadio.Checked)
            {
                CurrentSession.TotalCost += Math.Round(((CurrentSession.Duration / 60) * CurrentDevice.HourlyRateForMulti), 2);
            }
            else if (SingleRadio.Checked)
            {
                CurrentSession.TotalCost += Math.Round(((CurrentSession.Duration / 60) * CurrentDevice.HourlyRate), 2);
            }
            CurrentDevice.status = DevaisStatus.مشغول;
            sessionService.AddSessionFromService(CurrentSession);
            deviceService.UpdateDeviceFromService(CurrentDevice);
            StartBtn.Enabled = false;
            EndBtn.Enabled = true;
            dateTimePicker1.Enabled = false;
            MultiRadio.Enabled = false;
            SingleRadio.Enabled = false;
            ResetBtn.Enabled = false;
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            DateTime parsedTime;

            // Force DateTimePicker to take the current time if input is empty or invalid
            if (string.IsNullOrWhiteSpace(dateTimePickerEnd.Text) || !DateTime.TryParse(dateTimePickerEnd.Text, out parsedTime))
            {
                parsedTime = DateTime.Now;
                dateTimePickerEnd.Value = parsedTime;
            }

            // Set the DateTimePicker value to the valid parsed time
            dateTimePickerEnd.Value = parsedTime;

            timer.Stop();
            if (CurrentSession == null)
            {
                MessageBox.Show("يرجي بدا الجلسه قبل بدايتها", "فشل في انهاء الجلسه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CurrentSession.EndTime = dateTimePickerEnd.Value; //DateTime.Now;
            CurrentSession.Status = "Closed";
            if (CurrentSession.EndTime.HasValue)
            {
                CurrentSession.Duration = (decimal)(CurrentSession.EndTime.Value - CurrentSession.StartTime).TotalMinutes;
            }


            var currentDuration = CurrentSession.Duration;
            if (MultiRadio.Checked)
            {
                CurrentSession.TotalCost += Math.Round((currentDuration / 60) * CurrentDevice.HourlyRateForMulti, 2);
            }
            else if (SingleRadio.Checked)
            {
                CurrentSession.TotalCost += Math.Round((currentDuration / 60) * CurrentDevice.HourlyRate, 2);
            }




            //CurrentSession.TotalCost += Math.Round(((CurrentSession.Duration / 60) * CurrentDevice.HourlyRate), 2);

            sessionService.UpdateSessionFromService(CurrentSession);
            TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();

            CurrentDevice.status = DevaisStatus.متاح;
            deviceService.UpdateDeviceFromService(CurrentDevice);
            StartBtn.Enabled = true;
            EndBtn.Enabled = false;
            dateTimePicker1.Enabled = true;
            MultiRadio.Enabled = true;
            SingleRadio.Enabled = true;
            ResetBtn.Enabled = true;
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
            //StartBtn.Enabled = !dateTimePicker1.Checked;
            ValidateDateTime();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            int hours = elapsedSeconds / 3600;
            int minutes = (elapsedSeconds % 3600) / 60;
            int seconds = elapsedSeconds % 60;
            TimerLbl.Text = $"{hours}:{minutes}:{seconds}";
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            ValidateDateTime();
            StartBtn.Enabled = false;
        }
        private void ValidateDateTime()
        {
            if (DateTime.TryParse(dateTimePicker1.Text, out _))
            {
                StartBtn.Enabled = true;
            }
            else
            {
                StartBtn.Enabled = false;
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text) || !DateTime.TryParse(dateTimePicker1.Text, out DateTime parsedTime))
            {
                parsedTime = DateTime.Now; // Default to current time if input is invalid
                dateTimePicker1.Value = parsedTime;
            }
        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrderGrid.Columns[e.ColumnIndex].Name == "DeleteBtb" && e.RowIndex >= 0)
            {
                var id =(int) OrderGrid.Rows[e.RowIndex].Cells["Id"].Value;
                var OrderDetail = orderDetailsService.GetOrderDetailByIdFromService(id);
                CurrentSession.TotalCost -= (OrderDetail.Item.Price * OrderDetail.Quantity);
                TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();
                OrderDetail.Item.Stock += OrderDetail.Quantity;
                orderDetailsService.DeleteById(OrderDetail.Id);
            }
            PopulateOrderGrid();
        }

        private void ChangeSessionTypeBtn_Click(object sender, EventArgs e)
        {
            if (CurrentSession == null)
            {
                MessageBox.Show("يرجى بدء الجلسة قبل تغيير نوع الجلسة", "فشل في تغيير نوع الجلسة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the duration up to this point
            var currentDuration = (decimal)(DateTime.Now - CurrentSession.StartTime).TotalMinutes;

            // Calculate the cost up to this point based on the current session type
            if (MultiRadio.Checked)
            {
                CurrentSession.TotalCost += Math.Round((currentDuration / 60) * CurrentDevice.HourlyRateForMulti, 2);
            }
            else if (SingleRadio.Checked)
            {
                CurrentSession.TotalCost += Math.Round((currentDuration / 60) * CurrentDevice.HourlyRate, 2);
            }

            // Update the session start time to now
            CurrentSession.StartTime = DateTime.Now;

            // Change the session type
            if (MultiRadio.Checked)
            {
                SingleRadio.Checked = true;
                MultiRadio.Checked = false;
            }
            else if (SingleRadio.Checked)
            {
                MultiRadio.Checked = true;
                SingleRadio.Checked = false;
            }

            // Update the session in the database
            sessionService.UpdateSessionFromService(CurrentSession);

            // Update the total cost label
            TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();

            MessageBox.Show("تم تغيير نوع الجلسة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            OrderGrid.DataSource = null;
            CurrentSession = null;
            elapsedSeconds = 0;
            TimerLbl.Text = "00:00:00";
            TotalPriceLbl.Text = "0";
            StartBtn.Enabled = true;
            EndBtn.Enabled = false;
            dateTimePicker1.Enabled = true;
            MultiRadio.Enabled = true;
            SingleRadio.Enabled = true;

        }
    }
}
