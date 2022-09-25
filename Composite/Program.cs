
using Composite.Model.Nodes;

class Program
{
    static void Main(string[] args)
    {
        var eventCompositeNode = new EventNode();
        var eventNode = new EventNode();
        var subEventNode = new SubNode();
        var subEventId = subEventNode.GetId();

        // Add subEventNode
        eventNode.AddNode(subEventNode);
        // Add eventNode
        eventCompositeNode.AddNode(eventNode);
        // Execute eventNode
        eventCompositeNode.Execute(eventNode.GetId());
        // Execute subEventNode
        eventCompositeNode.Execute(subEventId);

        var gateCompositeNode = new GateNode();
        var gateNode = new GateNode();
        var subGateNode = new SubNode();
        var subGateId = subGateNode.GetId();
        // Add subGateNode
        gateNode.AddNode(subGateNode);
        // Add gateNode
        gateCompositeNode.AddNode(gateNode);

        // Execute subGateNode
        gateCompositeNode.Execute(gateNode.GetId());
        // Execute subGateId
        gateCompositeNode.Execute(subGateId);

        // Add gateCompositeNode (Composite Add Composite)
        eventCompositeNode.AddNode(gateCompositeNode);
        // Execute subGateId
        eventCompositeNode.Execute(subGateId);
    }
}