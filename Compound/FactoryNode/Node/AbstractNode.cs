using Compound.FactoryNode.Interface;

namespace Compound.FactoryNode.Node
{
    public abstract class AbstractNode : INode
    {
        public abstract bool SetValidation();
        public abstract void SetDetailList(string subDetail);
        public void SetDetailDialog(IWindow window)
        {
            window.OpenDialog(this);
        }
    }
}
