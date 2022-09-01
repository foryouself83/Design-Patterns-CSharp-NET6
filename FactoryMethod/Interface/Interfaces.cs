namespace FactoryMethod.Interface
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
        public bool GetValidation();
        public void SetDetailDialog(IWindow window);
    }
}
