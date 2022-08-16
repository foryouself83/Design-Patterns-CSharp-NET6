using Compound.FactoryNode;
using Compound.FactoryNode.Detail.Window;
using Compound.FactoryNode.Node;

class Program
{
    static void Main(string[] args)
    {
        var factoryNode = FactoryNode.GetNode<FactoryResponsibilityNode>();
        factoryNode.GetNode(Guid.NewGuid().ToString());
        factoryNode.GetNode(Guid.NewGuid().ToString());

        var nodes = factoryNode.GetResponsibilityNodes();

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

                foreach (var detail in node.SubDetails)
                    Console.WriteLine($"Sub Detail: {detail.Detail}");

                Console.WriteLine();
            }
        }
    }
}