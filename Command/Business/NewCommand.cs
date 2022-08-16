using Command.Command.Interface;

namespace Command.Command.Business
{
    internal class NewCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("불러오기");
        }
    }
}
