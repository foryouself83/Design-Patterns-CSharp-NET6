using Singleton;

class Program
{
    static void Main(string[] args)
    {
        var factoryNode = FactoryNode.GetInstance();

        Console.WriteLine($"{factoryNode.CreateNode()}");
    }
}