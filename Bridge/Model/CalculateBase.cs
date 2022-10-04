using Bridge.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Model
{
    internal abstract class CalculateBase
    {
        private ICalculate _calculateObj;
                
        public ICalculate CalculateObj { get => _calculateObj; set => _calculateObj = value; }

        public CalculateBase(ICalculate obj)
        {
            _calculateObj = obj;
        }

        public virtual float CalculateDivision()
        {
            return _calculateObj.CalculateDivision();
        }

        public virtual float CalculateSum()
        {
            return _calculateObj.CalculateSum();
        }
    }
}
