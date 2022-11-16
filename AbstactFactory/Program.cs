
using AbstactFactory.Model;
using AbstactFactory.Model.Factory;

class Program
{
    static void Main(string[] args)
    {
        var eventFactory = new EventNodeFactory();
        var gateFactory = new GateNodeFactory();

        eventFactory.CreateCutSetCalAlgorithm();
        gateFactory.CreateCutSetCalAlgorithm();

        eventFactory.CreateLogicalExpressionAlgorithm();
        gateFactory.CreateLogicalExpressionAlgorithm();
    }
}