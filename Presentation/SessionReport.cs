using PlayStation.Application.Services;
using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayStation.Presentation
{
    public partial class SessionReport : BaseForm
    {
        private readonly SessionService sessionService;
        public int PageSize = 10;
        public int CurrentPage = 1;

        private List<Session> CurrentSessions;
        public SessionReport(SessionService _sessionService)
        {
            InitializeComponent();
            ApplyGlobalStyles(this);
            sessionService = _sessionService;
            TotalLbl.Visible = false;
        }

        private void GenerateDailyReport(DateTime date)
        {
            CurrentSessions = sessionService.GetDailySessions(date);
            DisplaySessions();
            TotalLbl.Visible = true;
            decimal cashTotal = CurrentSessions.Where(s => !s.IsCredit).Sum(s => s.TotalCost);
            decimal creditTotal = CurrentSessions.Where(s => s.IsCredit).Sum(s => s.TotalCost);
            TotalLbl.Text = $"مجموع الايرادات النقدية: {cashTotal}\n" +
                    $"مجموع الايرادات الآجلة: {creditTotal}\n" +
                    $"المجموع الكلي: {cashTotal + creditTotal}";
        }

        private void GenerateWeeklyReport(DateTime date)
        {
            CurrentSessions = sessionService.GetWeeklySessions(date);
            DisplaySessions();
            TotalLbl.Visible = true;
            decimal cashTotal = CurrentSessions.Where(s => !s.IsCredit).Sum(s => s.TotalCost);
            decimal creditTotal = CurrentSessions.Where(s => s.IsCredit).Sum(s => s.TotalCost);

            TotalLbl.Text = $"مجموع الايرادات النقدية للأسبوع: {cashTotal}\n" +
                            $"مجموع الايرادات الآجلة للأسبوع: {creditTotal}\n" +
                            $"المجموع الكلي للأسبوع: {cashTotal + creditTotal}";
        }

        private void GenerateMonthlyReport(DateTime date)
        {
            CurrentSessions = sessionService.GetMonthlySessions(date);
            DisplaySessions();
            TotalLbl.Visible = true;
            decimal cashTotal = CurrentSessions.Where(s => !s.IsCredit).Sum(s => s.TotalCost);
            decimal creditTotal = CurrentSessions.Where(s => s.IsCredit).Sum(s => s.TotalCost);

            TotalLbl.Text = $"مجموع الايرادات النقدية للشهر: {cashTotal}\n" +
                            $"مجموع الايرادات الآجلة للشهر: {creditTotal}\n" +
                            $"المجموع الكلي للشهر: {cashTotal + creditTotal}";
        }

        private void DisplaySessions()
        {
            SessionsReportGrid.DataSource = null;

            int TotalSessions = CurrentSessions.Count;
            int TotalPages = (int)Math.Ceiling((double)TotalSessions / PageSize);
            int startIndex = (CurrentPage - 1) * PageSize;
            int RowHeight = SessionsReportGrid.RowTemplate.Height;
            int HeaderHeight = SessionsReportGrid.ColumnHeadersHeight;
            SessionsReportGrid.Height = (PageSize * RowHeight) + HeaderHeight;
            PreviousBtn.Enabled = CurrentPage > 1;
            NextBtn.Enabled = CurrentPage < TotalPages;
            SessionsReportGrid.DataSource = CurrentSessions.Select(s => new
            {
                s.Id,
                s.StartTime,
                s.EndTime,
                s.Status,
                s.TotalCost,
                IsCredit = s.IsCredit ? "اجل" : "نقدي",
                s.AmountPaid,
                s.ClientName,
                s.RemainingBalance,
                Duration = Math.Round(s.Duration / 60, 2).ToString(),
                //s.Duration,
                DeviceName = s.Device.Name
            }).Skip(startIndex)
                .Take(PageSize)
                .ToList();
            SessionsReportGrid.Columns["Id"].Visible = false;
            SessionsReportGrid.Columns["StartTime"].HeaderText = "وقت البدء";
            SessionsReportGrid.Columns["EndTime"].HeaderText = "وقت الانتهاء";
            SessionsReportGrid.Columns["Status"].HeaderText = "الحاله";
            SessionsReportGrid.Columns["TotalCost"].HeaderText = "المجموع";
            SessionsReportGrid.Columns["Duration"].HeaderText = "المدة";
            SessionsReportGrid.Columns["DeviceName"].HeaderText = "الجهاز";
            SessionsReportGrid.Columns["IsCredit"].HeaderText = "بالاجل";
            SessionsReportGrid.Columns["ClientName"].HeaderText = "العميل";
            SessionsReportGrid.Columns["AmountPaid"].HeaderText = "المدفوع";
            SessionsReportGrid.Columns["RemainingBalance"].HeaderText = "الباقي";
        }

        private void DailyReportBtn_Click(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker.Value;
            GenerateDailyReport(selectedDate);

        }

        private void WeeklyReportBtn_Click(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker.Value;
            GenerateWeeklyReport(selectedDate);
        }

        private void MonthlyReportBtn_Click(object sender, EventArgs e)
        {
            var selectedDate = dateTimePicker.Value;
            GenerateMonthlyReport(selectedDate);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            CurrentPage++;
            DisplaySessions();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            CurrentPage--;
            DisplaySessions();
        }

        private void SessionsReportGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }
    }
}
