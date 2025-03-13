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

    }
}
