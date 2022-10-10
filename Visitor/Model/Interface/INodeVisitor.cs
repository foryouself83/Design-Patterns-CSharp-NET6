using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Model.Interface
{
    internal interface INodeVisitor
    {
        void Visit(GateNode node);
        void Visit(EventNode node);
    }
}
