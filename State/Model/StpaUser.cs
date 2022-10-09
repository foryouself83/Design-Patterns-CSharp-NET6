using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Model
{
    internal class StpaUser : User
    {
        public override void GetReport()
        {
            Console.WriteLine("Only Support STPA Report");
        }
    }
}
