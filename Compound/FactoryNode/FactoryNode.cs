using Compound.FactoryNode.Interface;

namespace Compound.FactoryNode
{
    public class FactoryNode
    {
        private static FactoryNode? _instance = null;
        private Dictionary<Type, IFatoryNode> _factories = new Dictionary<Type, IFatoryNode>();
        public static object CreateNode(Type type)
        {
            // singleton pattern
            if (_instance == null)
                _instance = new FactoryNode();

            // flyweight pattern
            if (!_instance._factories.ContainsKey(type))
            {
                if (Activator.CreateInstance(type) is IFatoryNode node)
                    _instance._factories.Add(type, node);
            }

            return _instance._factories[type];
        }
        public static T CreateNode<T>() where T : IFatoryNode
        {
            return (T)CreateNode(typeof(T));
        }
    }
}
