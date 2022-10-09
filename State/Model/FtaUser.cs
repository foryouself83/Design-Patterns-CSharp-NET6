using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Model
{
    internal class FtaUser : User
    {
        public override void GetReport()
        {
            Console.WriteLine("Only Support FTA Report");
        }
    }
}
