using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    public class LoginSessionService
    {
        private readonly IRepository<LoginSession> loginSessionRepository;
        public LoginSessionService(IRepository<LoginSession> _loginSessionRepository)
        {
            loginSessionRepository = _loginSessionRepository;
        }
        public LoginSession GetLoginSessionByIdFromService(int id)
        {
            return loginSessionRepository.GetById(id);
        }
        public List<LoginSession> GetAllLoginSessionsFromService()
        {
            return loginSessionRepository.GetAll().ToList();
        }
        public void AddLoginSessionFromService(LoginSession loginSession)
        {
            loginSessionRepository.Add(loginSession);
        }
        public void UpdateLoginSessionFromService(LoginSession loginSession)
        {
            loginSessionRepository.Update(loginSession);
        }
        public void DeleteLoginSessionFromService(LoginSession loginSession)
        {
            loginSessionRepository.DeleteById(loginSession.Id);
        }
        public LoginSession GetLastLoginSessionFromService()
        {
            return loginSessionRepository.GetAll().Last();
        }
    }
}
