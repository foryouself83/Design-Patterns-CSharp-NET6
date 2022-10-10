using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Model.Interface;

namespace Visitor.Model
{
    internal class GroupNodes
    {
        private List<BaseNode> _nodes = new List<BaseNode>();

        public void Attach(BaseNode element)
        {
            _nodes.Add(element);
        }
        public void Detach(BaseNode element)
        {
            _nodes.Remove(element);
        }
        public void Accept(INodeVisitor visitor)
        {
            foreach (var node in _nodes)
            {
                node.Accept(visitor);
            }
        }
    }
}
