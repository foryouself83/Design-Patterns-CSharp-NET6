using State.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Interface
{
    internal interface IUser
    {
        public Model.User ChangeUserType(Enum.UserType userType);
        public void GetReport();
    }
}
