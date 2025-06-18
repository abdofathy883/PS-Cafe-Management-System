using PlayStation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Application.Services
{
    public class SessionTypeChangeService
    {
        
        private readonly IRepository<SessionTypeChanges> _repository;

        public SessionTypeChangeService(IRepository<SessionTypeChanges> repository)
        {
            _repository = repository;
        }

        public void AddTypeChange(SessionTypeChanges change)
        {
            _repository.Add(change);
        }

        public List<SessionTypeChanges> GetSessionTypeChanges(int sessionId)
        {
            return _repository.Find(x => x.SessionId == sessionId && !x.IsDeleted)
                            .OrderBy(x => x.ChangeTime)
                            .ToList();
        }
        
    }
}
