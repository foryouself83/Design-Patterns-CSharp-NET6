using Composite.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model.Nodes
{
    public class EventNode : CompositeNode
    {
        public EventNode() : base()
        {
        }
        public void AddNode(INode node)
        {
            children.Add(node);
        }
        public bool Remove(INode node)
        {
            return children.Remove(node);
        }
        public void RemoveAll()
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

            Console.WriteLine($"EventNode : {id}");
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
