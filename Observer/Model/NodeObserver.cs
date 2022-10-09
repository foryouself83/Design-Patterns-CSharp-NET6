
using Observer.Interface;

namespace Observer.Model
{
    internal abstract class NodeObserver : IObserver
    {
        public abstract void Update();
    }
}
