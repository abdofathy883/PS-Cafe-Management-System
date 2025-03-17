using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    public class SessionService
    {
        private readonly IRepository<Session> sessionRepository;
        public SessionService(IRepository<Session> _sessionRepository)
        {
            sessionRepository = _sessionRepository;
        }
        public void AddSessionFromService(Session session)
        {
            sessionRepository.Add(session);
        }
        public void UpdateSessionFromService(Session session)
        {
            sessionRepository.Update(session);
        }

        public void DeleteSessionFromService(Session session)
        {
            sessionRepository.DeleteById(session.Id);
        }

        //Reports
        public List<Session> GetSessionsByDateRange(DateTime startDate, DateTime endDate)
        {
            return sessionRepository.Find(s => s.StartTime >= startDate && s.StartTime <= endDate).ToList();
        }

        public List<Session> GetDailySessions(DateTime date)
        {
            return GetSessionsByDateRange(date.Date, date.Date.AddDays(1).AddTicks(-1));
        }

        public List<Session> GetWeeklySessions(DateTime date)
        {
            var startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek);
            var endOfWeek = startOfWeek.AddDays(7).AddTicks(-1);
            return GetSessionsByDateRange(startOfWeek, endOfWeek);
        }

        public List<Session> GetMonthlySessions(DateTime date)
        {
            var startOfMonth = new DateTime(date.Year, date.Month, 1);
            var endOfMonth = startOfMonth.AddMonths(1).AddTicks(-1);
            return GetSessionsByDateRange(startOfMonth, endOfMonth);
        }

    }
}
