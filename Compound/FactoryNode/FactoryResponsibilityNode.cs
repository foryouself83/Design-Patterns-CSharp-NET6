using Compound.FactoryNode.Node;

namespace Compound.FactoryNode
{
    public class FactoryResponsibilityNode : AbstractFactoryNode<ResponsibilityNode>
    {
        private List<ResponsibilityNode> _nodes = new();

        public override ResponsibilityNode GetNode(string uId)
        {
            if (_nodes.Find(x => x.UId == uId) is ResponsibilityNode node)
                return node;

            var item = new ResponsibilityNode(uId);
            _nodes.Add(item);

            return item;
        }

        public IList<ResponsibilityNode> GetResponsibilityNodes()
        {
            return _nodes;
        }
    }
}
