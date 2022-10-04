using Bridge.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Model
{
    internal class GateNode : ICalculate
    {
        private float _value;
        public float CalculateDivision()
        {
            Console.WriteLine("GateNode Division Calculate");
            return _value *= 0.01f;
        }

        public float CalculateSum()
        {
            Console.WriteLine("GateNode Sum Calculate");
            return _value += 0.01f;
        }
    }
}
