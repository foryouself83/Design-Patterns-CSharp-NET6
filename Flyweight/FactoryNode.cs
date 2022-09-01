using Flyweight.Interface;

namespace Flyweight.FactoryNode
{
    public class FactoryNode
    {
        private Dictionary<Type, INode> _factories = new Dictionary<Type, INode>();

        public INode CreateNode(Type type)
        {
            if (!_factories.ContainsKey(type))
            {
                // Reflection과 Type을 이용하여 동적으로 객체를 생성하고 생성된 객체를 비교하여 추가한다.
                if (Activator.CreateInstance(type) is INode node)
                    _factories.Add(type, node);
                else
                    throw new ArgumentException(nameof(type));
            }

            return _factories[type];
        }
        public T CreateNode<T>() where T : INode
        {
            return (T)CreateNode(typeof(T));
        }
    }
}
