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

namespace PlayStation.Presentation
{
    public partial class SessionReport : BaseForm
    {
        private readonly SessionService sessionService;
        //public int PageSize = 10;
        //public int CurrentPage = 1;
        //private int TotalPages()
        //{
        //    int totalUsers = deviceService.GetAllDevicesFromService().Count;
        //    return (int)Math.Ceiling((double)totalUsers / PageSize);
        //}
        public SessionReport(SessionService _sessionService)
        {
            InitializeComponent();
            ApplyGlobalStyles(this);
            sessionService = _sessionService;
            TotalLbl.Visible = false;
        }

        private void GenerateDailyReport(DateTime date)
        {
            var sessions = sessionService.GetDailySessions(date);
            DisplaySessions(sessions);
            TotalLbl.Visible = true;
            TotalLbl.Text = "مجموع الايرادات هذا اليوم: " + sessions.Sum(s => s.TotalCost).ToString();
        }

        private void GenerateWeeklyReport(DateTime date)
        {
            var sessions = sessionService.GetWeeklySessions(date);
            DisplaySessions(sessions);
            TotalLbl.Visible = true;
            TotalLbl.Text = "مجموع الايرادات هذا الاسبوع: " + sessions.Sum(s => s.TotalCost).ToString();
        }

        private void GenerateMonthlyReport(DateTime date)
        {
            var sessions = sessionService.GetMonthlySessions(date);
            DisplaySessions(sessions);
            TotalLbl.Visible = true;
            TotalLbl.Text = "مجموع الايرادات هذا الشهر: " + sessions.Sum(s => s.TotalCost).ToString();
        }

        private void DisplaySessions(List<Session> sessions)
        {
            SessionsReportGrid.DataSource = null;
            int PageSize = 10;
            int CurrentPage = 1;
            int TotalPages()
            {
                int totalUsers = sessions.Count;
                return (int)Math.Ceiling((double)totalUsers / PageSize);
            }
        int startIndex = (CurrentPage - 1) * PageSize;

            int RowHeight = SessionsReportGrid.RowTemplate.Height;
            int HeaderHeight = SessionsReportGrid.ColumnHeadersHeight;
            SessionsReportGrid.Height = (PageSize * RowHeight) + HeaderHeight;

            if (CurrentPage > 1)
            {
                PreviousBtn.Enabled = true;
            }
            if (CurrentPage < TotalPages())
            {
                NextBtn.Enabled = true;

            }
            // Assuming you have a DataGridView named SessionsGrid
            SessionsReportGrid.DataSource = sessions.Select(s => new
            {
                s.Id,
                s.StartTime,
                s.EndTime,
                s.Status,
                s.TotalCost,
                s.Duration,
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
            SessionsReportGrid.Columns["DeviceName"].HeaderText = "اسم الجهاز";
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
    }
}
