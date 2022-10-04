using Bridge.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Model
{
    internal class EventNode : ICalculate
    {
        private float _value;
        public float CalculateDivision()
        {
            Console.WriteLine("EventNode Division Calculate");
            return _value *= 0.1f;
        }

        public float CalculateSum()
        {
            Console.WriteLine("EventNode Sum Calculate");
            return _value += 0.1f;
        }
    }
}
