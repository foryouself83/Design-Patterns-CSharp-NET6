using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Interface
{
    internal interface ICalculate
    {
        /// <summary>
        /// 계산 Method
        /// </summary>
        /// <returns></returns>
        public double Calculate();
    }
}
