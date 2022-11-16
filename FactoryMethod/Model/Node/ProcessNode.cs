namespace FactoryMethod.Model.Node
{
    public class ProcessNode
    {
        private readonly string _preset = "PC-";
        private string _uid = string.Empty;
        private int _count = 0;

        public string UId => _uid;

        public ProcessNode(string uid)
        {
            _uid = uid;
        }
    }
}
