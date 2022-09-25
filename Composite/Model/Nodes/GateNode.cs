using Composite.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model.Nodes
{
    public class GateNode : CompositeNode
    {
        public GateNode() : base()
        {
        }
        public override void AddNode(INode node)
        {
            children.Add(node);
        }
        public override bool Remove(INode node)
        {
            return children.Remove(node);
        }
        public override void RemoveAll()
        {
            children.Clear();
        }

        public override string GetId()
        {
            return id;
        }

        public override void Execute()
        {
            if (!node.GetId().Equals(id)) return;
            
            Console.WriteLine($"GateNode : {id}");
        }
        public override void Execute(string id)
        {
            if (node.GetId().Equals(id))
                node.Execute();

            foreach (var child in children)
            {
                child.Execute(id);
            }
        }
    }
}
