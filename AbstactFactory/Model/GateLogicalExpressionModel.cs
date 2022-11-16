using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactory.Model
{
    internal class GateLogicalExpressionModel : LogicalExpressionModel
    {
        public GateLogicalExpressionModel()
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }
}
