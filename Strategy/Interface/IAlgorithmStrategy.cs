using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interface
{
    internal interface IAlgorithmStrategy
    {
        public double Calculate(double left, double right);
    }
}
