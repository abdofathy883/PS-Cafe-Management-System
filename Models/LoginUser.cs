using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStation.Models
{
    public class LoginUser
    {
        public User User
        {
            get;
            private set;
        }
        public static LoginUser Instance { get; } = new LoginUser();
        private LoginUser()
        {
            User = new User();
        }
        public void SetUser(User user)
        {
            User = user;
        }
        public static LoginUser GetInstance()
        {
            return Instance;
        }
    }
}
