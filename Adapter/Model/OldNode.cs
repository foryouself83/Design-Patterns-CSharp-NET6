using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Model
{
    /// <summary>
    /// Old Node Type
    /// </summary>
    internal class OldNode
    {
        private double _value;

        public OldNode(double value)
        {
            _value = value;
        }

        /// <summary>
        /// 기존 계산 방법
        /// </summary>
        /// <returns></returns>
        public double GetCutSet()
        {
            return _value * 0.001;
        }
    }
}
