using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Model.Interface;

namespace Visitor.Model
{
    internal class GateNode : BaseNode
    {
        public GateNode() : base("Gate")
        {
        }

        public override void Accept(INodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
