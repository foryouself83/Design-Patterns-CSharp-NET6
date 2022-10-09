using Observer.Business;
using Observer.Model;

namespace Observer.Structural
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            NodeSubject subject = new();
            subject.Attach(new GateNode(subject, 0.1f));
            subject.Attach(new GateNode(subject, 0.02f));
            subject.Attach(new GateNode(subject, 0.003f));

            subject.CutsetValue = 1.5f;
            Console.WriteLine($"NodeSubject CutsetValue : 1.5f");            
            subject.Notify();
        }
    }
}