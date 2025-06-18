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
        private readonly SessionTypeChangeService sessionTypeChangeService;
        Device CurrentDevice;
        Session? CurrentSession;
        private int elapsedSeconds;
        private bool isInputed = false;
        private SessionType CurrentSessionType;
        private decimal singleSessionCost = 0;
        private decimal multiSessionCost = 0;
        private DateTime? lastTypeChangeTime;

        public SingleDevice(int _CurrentDeviceId, CafeService _CafeService, SessionService _sessionService, DeviceService _deviceService, OrderDetailsService _orderDetailsService, SessionTypeChangeService _sessionTypeChangeService)
        {
            InitializeComponent();
            ApplyGlobalStyles(this);

            cafeService = _CafeService;
            sessionService = _sessionService;
            deviceService = _deviceService;
            orderDetailsService = _orderDetailsService;
            sessionTypeChangeService = _sessionTypeChangeService;

            CurrentDevice = deviceService.GetDeviceByIdFromService(_CurrentDeviceId);

            ItemsCombo.DataSource = cafeService.GetCafeItemsFromService();
            ItemsCombo.DisplayMember = "Name";
            ItemsCombo.ValueMember = "Id";
            if (CurrentDevice.status == DevaisStatus.مشغول)
            {
                CurrentSession = CurrentDevice.Sessions.First(s => s.Status == "Active");

                // Calculate costs from previous type changes
                var typeChanges = sessionTypeChangeService.GetSessionTypeChanges(CurrentSession.Id);
                foreach (var change in typeChanges)
                {
                    if (change.OldType == SessionType.Single)
                        singleSessionCost += change.CostUntilChange;
                    else
                        multiSessionCost += change.CostUntilChange;
                }

                if (CurrentSession.Type == SessionType.Multi)
                {
                    MultiRadio.Checked = true;
                    SingleRadio.Checked = false;
                    CurrentSessionType = SessionType.Multi;
                }
                else if (CurrentSession.Type == SessionType.Single)
                {
                    SingleRadio.Checked = true;
                    MultiRadio.Checked = false;
                    CurrentSessionType = SessionType.Single;
                }

                elapsedSeconds = ((int)(DateTime.Now - CurrentSession.StartTime).TotalSeconds);
                timer.Start();
                TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();
                StartBtn.Enabled = false;
            }

            DeviceNameLbl.Text = CurrentDevice.Name;
            PopulateOrderGrid();
        }
        private void PopulateOrderGrid()
        {
            if (CurrentSession != null)
            {
                var CurrentOrderList = CurrentSession.OrderDetails.Where(d => d.IsDeleted == false)
                    .Select(o => new { o.Id, o.Item.Name, o.Quantity, o.TotalPrice })
                    .ToList();
                OrderGrid.DataSource = null;
                OrderGrid.DataSource = CurrentOrderList;
                OrderGrid.Columns["Id"].Visible = false;
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
            }
            if (ItemsCounter.Value <= 0)
            {
                MessageBox.Show("يرجى اختيار عدد الوحدات المستخدمة من هذا المنتج", "فشل اضافة منتج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
                OrderDetail orderDetail = new()
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
            if (MultiRadio.Checked)
            {
                CurrentSessionType = SessionType.Multi;
            }
            else if (SingleRadio.Checked)
            {
                CurrentSessionType = SessionType.Single;

            }

            DateTime startTime;
            if (!isInputed)
            {
                startTime = DateTime.Now;
                dateTimePicker1.Value = startTime;
                isInputed = false;
            }
            else
            {
                startTime = dateTimePicker1.Value;
            }

            elapsedSeconds = 0;
            TimerLbl.Text = "00:00:00";
            timer.Start();
            CurrentSession = new Session()
            {
                Id = 0,
                DeviceId = CurrentDevice.Id,
                StartTime = startTime,
                EndTime = null,
                Status = "Active",
                TotalCost = 0,
                Duration = 0,
                Type = CurrentSessionType,
                OrderDetails = new List<OrderDetail>()
            };

            CurrentDevice.status = DevaisStatus.مشغول;
            sessionService.AddSessionFromService(CurrentSession);
            deviceService.UpdateDeviceFromService(CurrentDevice);
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            if (CurrentSession == null)
            {
                MessageBox.Show("يرجي بدا الجلسه قبل بدايتها", "فشل في انهاء الجلسه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime endTime;
            if (dateTimePickerEnd.Value == dateTimePickerEnd.MinDate || dateTimePickerEnd.Value == DateTimePicker.MinimumDateTime)
            {
                endTime = DateTime.Now;
                dateTimePickerEnd.Value = endTime;
            }
            else
            {
                endTime = dateTimePickerEnd.Value;
            }

            if (CurrentSession.StartTime.Year == endTime.Year &&
                CurrentSession.StartTime.Month == endTime.Month &&
                CurrentSession.StartTime.Day == endTime.Day &&
                CurrentSession.StartTime.Hour == endTime.Hour &&
                CurrentSession.StartTime.Minute == endTime.Minute)
            {
                MessageBox.Show("لا يمكن إنهاء الجلسة في نفس الدقيقة التي بدأت فيها", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            timer.Stop();

            CurrentSession.EndTime = endTime;
            //CurrentSession.Status = "مغلق";
            CurrentSession.Status = DevaisStatus.مشغول.ToString();
            if (CurrentSession.EndTime.HasValue)
            {
                if (CurrentSession.EndTime < CurrentSession.StartTime)
                {
                    CurrentSession.EndTime = CurrentSession.EndTime.Value.AddDays(1);
                }

                CurrentSession.Duration = (decimal)(CurrentSession.EndTime.Value - CurrentSession.StartTime).TotalMinutes;
            }

            // Calculate final session cost based on the current type
            var finalDuration = (decimal)(endTime - (lastTypeChangeTime ?? CurrentSession.StartTime)).TotalMinutes;
            if (CurrentSession.Type == SessionType.Multi)
            {
                multiSessionCost += Math.Round((finalDuration / 60) * CurrentDevice.HourlyRateForMulti);
            }
            else
            {
                singleSessionCost += Math.Round((finalDuration / 60) * CurrentDevice.HourlyRate);
            }

            // Calculate total session cost
            decimal totalSessionCost = singleSessionCost + multiSessionCost;
            decimal cafeteriaCost = CurrentSession.OrderDetails.Sum(od => od.Quantity * od.UnitPrice);
            var TotalSessionCost = totalSessionCost + cafeteriaCost;

            // Update UI labels
            TotalPriceLbl.Text = TotalSessionCost.ToString();
            TotalHoursLbl.Text = Math.Round(finalDuration / 60, 2).ToString();
            MultiPriceLbl.Text = Math.Round(multiSessionCost).ToString();
            SinglePriceLbl.Text = Math.Round(singleSessionCost).ToString();
            CafeteriaPriceLbl.Text = Math.Round(cafeteriaCost).ToString();

            CurrentDevice.status = DevaisStatus.متاح;
            deviceService.UpdateDeviceFromService(CurrentDevice);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value;
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
            StartBtn.Enabled = true;
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

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrderGrid.Columns[e.ColumnIndex].Name == "DeleteBtb" && e.RowIndex >= 0)
            {
                var id = (int)OrderGrid.Rows[e.RowIndex].Cells["Id"].Value;
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

            var currentTime = DateTime.Now;
            var durationSinceLastChange = (decimal)(currentTime - (lastTypeChangeTime ?? CurrentSession.StartTime)).TotalMinutes;
            var costForPeriod = 0m;

            // Calculate and add the cost for the current period
            if (CurrentSession.Type == SessionType.Multi)
            {
                costForPeriod = Math.Round((durationSinceLastChange / 60) * CurrentDevice.HourlyRateForMulti, 2);
                multiSessionCost += costForPeriod;

                // Record the type change
                var typeChange = new SessionTypeChanges
                {
                    SessionId = CurrentSession.Id,
                    ChangeTime = currentTime,
                    OldType = SessionType.Multi,
                    NewType = SessionType.Single,
                    CostUntilChange = costForPeriod
                };
                sessionTypeChangeService.AddTypeChange(typeChange);

                CurrentSession.Type = SessionType.Single;
                CurrentSessionType = SessionType.Single;
                SingleRadio.Checked = true;
                MultiRadio.Checked = false;
            }
            else if (CurrentSession.Type == SessionType.Single)
            {
                costForPeriod = Math.Round((durationSinceLastChange / 60) * CurrentDevice.HourlyRate, 2);
                singleSessionCost += costForPeriod;

                // Record the type change
                var typeChange = new SessionTypeChanges
                {
                    SessionId = CurrentSession.Id,
                    ChangeTime = currentTime,
                    OldType = SessionType.Single,
                    NewType = SessionType.Multi,
                    CostUntilChange = costForPeriod
                };
                sessionTypeChangeService.AddTypeChange(typeChange);

                CurrentSession.Type = SessionType.Multi;
                CurrentSessionType = SessionType.Multi;
                SingleRadio.Checked = false;
                MultiRadio.Checked = true;
            }

            lastTypeChangeTime = currentTime;

            // Update the total cost
            CurrentSession.TotalCost = singleSessionCost + multiSessionCost +
                CurrentSession.OrderDetails.Sum(od => od.Quantity * od.UnitPrice);

            sessionService.UpdateSessionFromService(CurrentSession);

            TotalPriceLbl.Text = CurrentSession.TotalCost.ToString();
            SinglePriceLbl.Text = singleSessionCost.ToString();
            MultiPriceLbl.Text = multiSessionCost.ToString();

            MessageBox.Show(
                $"تم تغيير نوع الجلسة بنجاح\n" +
                $"تكلفة الجلسة الفردية حتى الآن: {singleSessionCost:F2}\n" +
                $"تكلفة الجلسة المتعددة حتى الآن: {multiSessionCost:F2}",
                "نجاح",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            OrderGrid.DataSource = null;
            CurrentSession = null;
            elapsedSeconds = 0;
            singleSessionCost = 0;
            multiSessionCost = 0;
            lastTypeChangeTime = null;
            TimerLbl.Text = "00:00:00";
            TotalHoursLbl.Text = "0.00";
            TotalPriceLbl.Text = "0.00";
            SinglePriceLbl.Text = "0";
            MultiPriceLbl.Text = "0";
            CafeteriaPriceLbl.Text = "0";
            StartBtn.Enabled = true;
            EndBtn.Enabled = true;
            dateTimePicker1.Enabled = true;
            MultiRadio.Enabled = true;
            SingleRadio.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            isInputed = true;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            isInputed = true;
        }

        private void TotalCostInput_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentSession != null)
            {
                decimal totalCost = singleSessionCost + multiSessionCost +
                    CurrentSession.OrderDetails.Sum(od => od.Quantity * od.UnitPrice);
                decimal remainingBalance = totalCost - AmountPaidInput.Value;

            }
        }

        private void ConfirmPaymentBtn_Click(object sender, EventArgs e)
        {
            if (CurrentSession is null)
            {
                MessageBox.Show("لا توجد جلسة نشطة", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalCost = singleSessionCost + multiSessionCost +
                CurrentSession.OrderDetails.Sum(od => od.Quantity * od.UnitPrice);
            decimal amountPaid = AmountPaidInput.Value;

            if (IsCreditCheckBox.Checked && string.IsNullOrWhiteSpace(ClientNameInput.Text))
            {
                MessageBox.Show("يرجى إدخال اسم العميل للدفع بالأجل", "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrentSession.TotalCost = totalCost;
            CurrentSession.AmountPaid = amountPaid;
            CurrentSession.RemainingBalance = totalCost - amountPaid;
            CurrentSession.IsCredit = IsCreditCheckBox.Checked;
            CurrentSession.ClientName = IsCreditCheckBox.Checked ? ClientNameInput.Text : "نقدي";

            sessionService.UpdateSessionFromService(CurrentSession);
        }

        private void IsCreditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClientNameInput.Enabled = IsCreditCheckBox.Checked;
            if (IsCreditCheckBox.Checked)
            {
                ClientNameInput.Text = string.Empty;
            }
            else
            {
                ClientNameInput.Text = "نقدي";
            }
        }
    }
}
