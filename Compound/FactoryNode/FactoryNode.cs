using Compound.FactoryNode.Interface;

namespace Compound.FactoryNode
{
    public class FactoryNode
    {
        private static FactoryNode? _instance = null;
        private Dictionary<Type, IFatoryNode> _factories = new Dictionary<Type, IFatoryNode>();

        /// <summary>
        /// Singleton pattern
        /// </summary>
        /// <returns></returns>
        public static FactoryNode GetInstance()
        {
            // instance가 null 일경우 생성하여 1개의 객체를 유지하도록 한다.
            if (_instance == null)
                _instance = new FactoryNode();

            return _instance;
        }
        /// <summary>
        /// Flyweight pattern
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public object CreateNode(Type type)
        {
            if (!_factories.ContainsKey(type))
            {
                // Reflection과 Type을 이용하여 동적으로 객체를 생성하고 생성된 객체를 비교하여 추가한다.
                if (Activator.CreateInstance(type) is IFatoryNode node)
                    _factories.Add(type, node);
                else
                    throw new ArgumentException(nameof(type));
            }

            return _factories[type];
        }
        public T CreateNode<T>() where T : IFatoryNode
        {
            return (T)CreateNode(typeof(T));
        }
    }
}
