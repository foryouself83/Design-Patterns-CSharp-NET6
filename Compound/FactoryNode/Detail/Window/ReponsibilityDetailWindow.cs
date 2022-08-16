using Compound.FactoryNode.Interface;

namespace Compound.FactoryNode.Detail.Window
{
    public class ReponsibilityDetailWindow : IWindow
    {
        private int _detailCount = 0;
        public void OpenDialog(INode node)
        {
            node.SetDetailList($"sub Reponsibility Detail {++_detailCount}");
        }
    }
}
