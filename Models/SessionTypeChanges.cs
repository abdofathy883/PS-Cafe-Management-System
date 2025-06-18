using PlayStation.Infrastructure.Repos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Models
{
    public class SessionTypeChanges : IDeletable
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public virtual Session? Session { get; set; }
        public DateTime ChangeTime { get; set; }
        public SessionType OldType { get; set; }
        public SessionType NewType { get; set; }
        public decimal CostUntilChange { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
