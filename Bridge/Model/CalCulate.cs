using Bridge.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Model
{
    internal class CalCulate : CalculateBase
    {
        public CalCulate(ICalculate obj) : base(obj)
        {            
        }

        public override float CalculateSum()
        {
            Console.WriteLine("Abstraction Calculate Sum");
            return base.CalculateSum();
        }
        public override float CalculateDivision()
        {
            Console.WriteLine("Abstraction Calculate Division");
            return base.CalculateDivision();
        }
    }
}
