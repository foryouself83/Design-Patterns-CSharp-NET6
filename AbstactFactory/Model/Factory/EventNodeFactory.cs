using AbstactFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactFactory.Model.Factory
{
    internal class EventNodeFactory : AbstractFactoryNode
    {
        public override CutSetCalModel CreateCutSetCalAlgorithm()
        {
            return new EventCutSetCalModel();
        }

        public override LogicalExpressionModel CreateLogicalExpressionAlgorithm()
        {
            return new EventLogicalExpressionModel();
        }
    }
}
