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
        // 식별을 위한 id
        protected string id;

        // 자기 자신을 나타내는 Node
        protected INode node;
        // 자식 node
        protected List<INode> children = new List<INode>();

        public abstract string GetId();
        public abstract void Execute();
        public abstract void Execute(string id);
        /// <summary>
        /// Add Child Node
        /// </summary>
        /// <param name="node"></param>
        public abstract void AddNode(INode node);
        /// <summary>
        /// Remove Child Node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public abstract bool Remove(INode node);
        /// <summary>
        /// Clear Child Node
        /// </summary>
        public abstract void RemoveAll();

        /// <summary>
        /// ID 입력 없이 생성시 GUID를 생성
        /// </summary>
        public CompositeNode() : this(Guid.NewGuid().ToString()) { }
        /// <summary>
        /// ID를 입력하여 생성
        /// </summary>
        /// <param name="id"></param>
        public CompositeNode(string id)
        {
            this.id = id;
            node = this;
        }

    }
}
