using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Model
{
    internal class UserContext
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                Console.WriteLine($"{User.ToString()}");
            }
        }
        public UserContext()
        {
            _user = new GuestUser();
        }
        public void SetUserType(Enum.UserType userType)
        {
            var user = _user.ChangeUserType(userType);
            _user = user;
        }
        public void Report()
        {
            _user.GetReport();
        }
    }
}
