using Composite.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model.Nodes
{
    public abstract class CompositeNode : INode
    {
        protected string id;

        protected INode node;
        protected List<INode> children = new List<INode>();

        public abstract string GetId();
        public abstract void Execute();
        public abstract void Execute(string id);

        public CompositeNode() : this(Guid.NewGuid().ToString()) { }
        public CompositeNode(string id)
        {
            this.id = id;
            node = this;
        }

    }
}
