using Compound.FactoryNode;
using Compound.FactoryNode.Detail.Window;
using Compound.FactoryNode.Node;

class Program
{
    static void Main(string[] args)
    {
        var factoryNode = FactoryNode.GetInstance();

        var responsibilityNodes = factoryNode.CreateNode<FactoryResponsibilityNode>();
        responsibilityNodes.CreateNode(Guid.NewGuid().ToString());
        responsibilityNodes.CreateNode(Guid.NewGuid().ToString());

        var nodes = responsibilityNodes.GetResponsibilityNodes();

        foreach (ResponsibilityNode node in nodes)
        {
            var window = new ReponsibilityDetailWindow();
            node.SetDetailDialog(window);
            node.SetDetailDialog(window);
            node.SetDetailDialog(window);
            node.SetDetailDialog(window);
            node.SetDetailDialog(window);
        }

        if (nodes.Any())
        {
            foreach (var node in nodes)
            {
                Console.WriteLine($"Node Id: {node.UId}");

                foreach (var detail in node.GetEnumerator())
                    Console.WriteLine($"Sub Detail: {detail.Detail}");

                Console.WriteLine();
            }
        }
    }
}