using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactory.Model
{
    internal class EventLogicalExpressionModel : LogicalExpressionModel
    {
        public EventLogicalExpressionModel()
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }
}
