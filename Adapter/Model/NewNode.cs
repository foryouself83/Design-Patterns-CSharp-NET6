using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Model.Interface;

namespace Adapter.Model
{
    internal class NewNode : ICalculate
    {
        /// <summary>
        /// New Node Type
        /// </summary>
        private double _cutset;
        public NewNode(double cutset)
        {
            _cutset = cutset;
        }
        public double Calculate()
        {
            return GetCutSet();
        }
        /// <summary>
        /// 신규 계산 공식
        /// </summary>
        /// <returns></returns>

        public double GetCutSet()
        {
            return _cutset * 0.1;
        }
    }
}
