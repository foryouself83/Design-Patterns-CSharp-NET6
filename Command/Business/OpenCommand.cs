using Command.Command.Interface;

namespace Command.Command.Business
{
    internal class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("불러오기");
        }
    }
}
