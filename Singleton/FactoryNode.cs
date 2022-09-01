namespace Singleton
{
    internal class FactoryNode
    {
        private static FactoryNode? _instance = null;

        public static FactoryNode GetInstance()
        {
            // instance가 null 일경우 생성하여 1개의 객체를 유지하도록 한다.
            if (_instance == null)
                _instance = new FactoryNode();

            return _instance;
        }
        public string CreateNode()
        {
            return "Create Node";
        }
    }
}
