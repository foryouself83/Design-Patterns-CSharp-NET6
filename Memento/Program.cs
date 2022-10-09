using Memento.Model;
using System;
namespace Memento.Structural
{    public class Program
    {
        public static void Main(string[] args)
        {
            var gate = new GateNode();
            gate.SetTag("SA");
            var saMemento = gate.CreateModelMemento();
            Console.WriteLine($"Tag : {gate.Tag}");

            gate.SetTag("STPA");
            var stpaMemento = gate.CreateModelMemento();
            Console.WriteLine($"Tag : {gate.Tag}");

            gate.SetTag("FTA");
            var ftaMemento = gate.CreateModelMemento();
            Console.WriteLine($"Tag : {gate.Tag}");

            gate.SetNodeMemento(saMemento);
            Console.WriteLine($"Tag : {gate.Tag}");

            gate.SetNodeMemento(stpaMemento);
            Console.WriteLine($"Tag : {gate.Tag}");

            gate.SetNodeMemento(ftaMemento);
            Console.WriteLine($"Tag : {gate.Tag}");
        }
    }
}