using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Model.Interface
{
    internal interface ICalculate
    {
        /// <summary>
        /// + 계산 Method
        /// </summary>
        /// <returns></returns>
        public float CalculateSum();

        /// <summary>
        /// / 계산 Method
        /// </summary>
        /// <returns></returns>
        public float CalculateDivision();

    }
}
