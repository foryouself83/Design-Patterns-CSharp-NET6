
namespace FactoryMethod.Node
{
    public class ResponsibilityNode
    {
        private readonly string _preset = "LS-";
        private string _uid = string.Empty;
        private int _count = 0;

        public string UId => _uid;

        public ResponsibilityNode(string uid)
        {
            _uid = uid;
        }
    }
}
