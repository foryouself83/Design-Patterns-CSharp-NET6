using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Model;
using Visitor.Model.Interface;

namespace Visitor.Business
{
    internal class SafetyCalcVisitor : INodeVisitor
    {
        public void Visit(GateNode node)
        {
            Console.WriteLine($"{node.ToString()} visited by {this.GetType().Name}");
        }

        public void Visit(EventNode node)
        {
            Console.WriteLine($"{node.ToString()} visited by {this.GetType().Name}");
        }
    }
}
