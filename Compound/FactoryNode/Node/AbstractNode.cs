using Compound.FactoryNode.Interface;

namespace Compound.FactoryNode.Node
{
    public abstract class AbstractNode<T> : INode
    {
        public abstract bool GetValidation();
        public abstract void SetDetailList(string subDetail);
        public void SetDetailDialog(IWindow window)
        {
            window.OpenDialog(this);
        }
        public abstract IEnumerable<T> GetEnumerator();
    }
}
