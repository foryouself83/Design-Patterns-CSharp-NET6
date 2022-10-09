using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Model
{
    internal class GuestUser : User
    {
        public override void GetReport()
        {
            Console.WriteLine("Not Support Report");
        }
    }
}
