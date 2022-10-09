using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Model
{
    internal class AndGateAlgorithm : AlgorithmStrategy
    {

        public override double Calculate(double left, double right)
        {
            Console.Write("AndGateAlgorithm: ");
            return left + right;
        }
    }
}
