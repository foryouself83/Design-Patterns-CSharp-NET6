
using Flyweight.Interface;

namespace Flyweight.Node
{
    public class ProcessNode : AbstractNode
    {
        private string _uid = string.Empty;

        public string UId => _uid;

        public ProcessNode()
        {
        }

        public override INode SetUid(string uId)
        {
            _uid = uId;

            return this;
        }

        public override string GetUid() => _uid;
    }
}
