using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Model.Interface;

namespace Adapter.Model
{
    /// <summary>
    /// Adapter
    /// </summary>
    internal class AdapterNode : ICalculate
    {
        /// <summary>
        /// Old Node
        /// </summary>
        private OldNode _old;

        public AdapterNode(double value)
        {
            _old = new OldNode(value);
        }
        /// <summary>
        /// 공통된 Interface에 Old Node의 Method를 호출
        /// </summary>
        /// <returns></returns>
        public double Calculate()
        {
            return _old.GetCutSet();
        }
    }
}
