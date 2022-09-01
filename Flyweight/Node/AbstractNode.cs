using Flyweight.Interface;

namespace Flyweight.Node
{
    public abstract class AbstractNode : INode
    {
        public abstract string GetUid();

        // factory method pattern
        public abstract INode SetUid(string uId);
    }
}
