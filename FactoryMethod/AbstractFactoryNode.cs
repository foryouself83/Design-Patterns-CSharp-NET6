using FactoryMethod.Interface;

namespace FactoryMethod
{
    public abstract class AbstractFactoryNode<T> : IFatoryNode
    {
        // factory method pattern
        public abstract T CreateNode(string uId);
    }
}
