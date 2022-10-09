using Strategy.Model;

public class Program
{
    public static void Main(string[] args)
    {
        // AndGateAlgorithm Strategy
        var node = new Node(new AndGateAlgorithm(), 1.0f);
        Console.WriteLine($"{node.Calculate(0.9f)}");

        // OrGateAlgorithm Strategy
        node = new Node(new OrGateAlgorithm(), 1.0f);
        Console.WriteLine($"{node.Calculate(0.9f)}");

        // XorGateAlgorithm Strategy
        node = new Node(new XorGateAlgorithm(), 1.0f);
        Console.WriteLine($"{node.Calculate(0.9f)}");
    }
}