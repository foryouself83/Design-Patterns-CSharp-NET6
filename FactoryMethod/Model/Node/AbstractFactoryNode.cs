using FactoryMethod.Model.Interface;

namespace FactoryMethod.Model.Node
{
    public abstract class AbstractFactoryNode<T> : IFatoryNode
    {
        // factory method pattern
        public abstract T CreateNode(string uId);
    }
}
