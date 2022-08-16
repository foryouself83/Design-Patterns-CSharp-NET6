using Compound.FactoryNode.Interface;

namespace Compound.FactoryNode
{
    public abstract class AbstractFactoryNode<T> : IFatoryNode
    {
        // factory method pattern
        public abstract T GetNode(string uId);
    }
}
