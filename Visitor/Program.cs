using Visitor.Business;
using Visitor.Model;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Group Node
        GroupNodes nodes = new GroupNodes();

        // Attach Nodes
        nodes.Attach(new GateNode());
        nodes.Attach(new GateNode());
        nodes.Attach(new EventNode());
        nodes.Attach(new EventNode());

        // Cutset Calculate
        var cutSetVisitor = new CutSetCalcVisitor();
        Console.WriteLine("Start CutSetCalculate");
        nodes.Accept(cutSetVisitor);

        // Safety Calculate
        var safetyVisitor = new SafetyCalcVisitor();
        Console.WriteLine("Start SafetyCalculate");
        nodes.Accept(safetyVisitor);
    }
}