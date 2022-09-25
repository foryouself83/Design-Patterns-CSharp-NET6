using Composite.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model.Nodes
{
    public class SubNode : INode
    {
        private readonly string _id;

        public SubNode()
        {
            _id = Guid.NewGuid().ToString();
        }
        public void Execute()
        {
            Console.WriteLine($"SubNode : {_id}");
        }
        public void Execute(string id)
        {
            if (!id.Equals(_id)) return;

            Execute();
        }

        public string GetId()
        {
            return _id;
        }
    }
}
