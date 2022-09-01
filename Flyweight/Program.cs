using Flyweight.FactoryNode;
using Flyweight.Node;

class Program
{
    static void Main(string[] args)
    {
        var factoryNode = new FactoryNode();

        var processNodes = factoryNode.CreateNode<ProcessNode>();

        if (processNodes is ProcessNode node)
        {
            node.SetUid("test");
        }

        var existNode = factoryNode.CreateNode<ProcessNode>();

        Console.WriteLine($"Node Id: {existNode.GetUid()}");
    }
}