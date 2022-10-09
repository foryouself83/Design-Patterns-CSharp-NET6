using Observer.Interface;
using Observer.Model;

namespace Observer.Business
{
    internal abstract class Subject : ISubject
    {
        private List<NodeObserver> _observers = new();
        public void Attach(NodeObserver observer)
        {
            Console.WriteLine($"Subject Attach: {observer.ToString()}");
            _observers.Add(observer);
        }
        public void Detach(NodeObserver observer)
        {
            Console.WriteLine($"Subject Detach: {observer.ToString()}");
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (NodeObserver observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
