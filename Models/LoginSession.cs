using PlayStation.Infrastructure.Repos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Models
{
    public class LoginSession:IDeletable
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public bool IsLoggedOut { get; set; } =false;
        public bool IsDeleted { get; set; } = false;
        public virtual User User { get; set; }

    }
}
