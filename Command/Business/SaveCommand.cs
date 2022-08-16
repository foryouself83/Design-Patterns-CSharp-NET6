using Command.Command.Interface;

namespace Command.Command.Business
{
    internal class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("저장");
        }
    }
}
