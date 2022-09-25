using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Model.Interface
{
    public interface INode
    {
        public string GetId();
        public void Execute();
        public void Execute(string id);
    }
}
