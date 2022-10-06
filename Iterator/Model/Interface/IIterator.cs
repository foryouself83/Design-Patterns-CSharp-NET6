
namespace Iterator.Model.Interface
{
    internal interface IIterator<T>
    {
        T? First();
        T? Next();
        bool IsDone { get; }
        T? CurrentItem { get; }
    }
}
