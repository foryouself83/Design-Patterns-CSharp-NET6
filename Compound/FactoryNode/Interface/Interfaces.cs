namespace Compound.FactoryNode.Interface
{
    public interface IWindow
    {
        void OpenDialog(INode node);
    }
    public interface IFatoryNode
    {
    }
    public interface INode
    {
        public void SetDetailList(string subDetail);
        public bool SetValidation();
        public void SetDetailDialog(IWindow window);
    }
}
