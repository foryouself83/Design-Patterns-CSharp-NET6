using Observer.Model;

namespace Observer.Interface
{
    internal interface ISubject
    {
        public void Attach(NodeObserver observer);
        public void Detach(NodeObserver observer);
        public void Notify();
    }
}
