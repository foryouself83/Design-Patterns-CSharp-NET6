using FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        var factoryNode = FactoryNode.GetInstance();

        var responsibilityNodes = factoryNode.CreateNode<FactoryResponsibilityNode>();
        responsibilityNodes.CreateNode(Guid.NewGuid().ToString());
        responsibilityNodes.CreateNode(Guid.NewGuid().ToString());

        var nodes = responsibilityNodes.GetResponsibilityNodes();

        if (nodes.Any())
        {
            foreach (var node in nodes)
            {
                Console.WriteLine($"Node Id: {node.UId}");
                Console.WriteLine();
            }
        }
    }
}