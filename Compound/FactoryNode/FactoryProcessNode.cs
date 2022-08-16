using Compound.FactoryNode.Node;

namespace Compound.FactoryNode
{
    public class FactoryProcessNode : AbstractFactoryNode<ProcessNode>
    {
        private List<ProcessNode> _nodes = new();

        public override ProcessNode CreateNode(string uId)
        {
            if (_nodes.Find(x => x.UId == uId) is ProcessNode node)
                return node;

            var item = new ProcessNode(uId);
            _nodes.Add(item);

            return item;
        }
        public IList<ProcessNode> GetProcessNodes()
        {
            return _nodes;
        }

    }
}
