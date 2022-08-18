using Command.Command.Interface;

namespace Command.Command.Business
{
    internal class NewCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("새로 만들기");
        }
    }
}
