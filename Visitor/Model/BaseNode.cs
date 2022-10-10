using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Model.Interface;

namespace Visitor.Model
{
    internal abstract class BaseNode
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract void Accept(INodeVisitor visitor);

        public BaseNode(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = string.Empty;
        }
    }
}
