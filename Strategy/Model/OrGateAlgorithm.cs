using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Model
{
    internal class OrGateAlgorithm : AlgorithmStrategy
    {
        public override double Calculate(double left, double right)
        {
            Console.Write("OrGateAlgorithm: ");
            return left * right;
        }
    }
}
