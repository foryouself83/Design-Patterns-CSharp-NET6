using Compound.FactoryNode.Interface;

namespace Compound.FactoryNode.Detail.Window
{
    public class ProcessDetailWindow : IWindow
    {
        private int _detailCount = 0;
        public void OpenDialog(INode node)
        {
            node.SetDetailList($"sub Process Detail {++_detailCount}");
        }
    }
}
