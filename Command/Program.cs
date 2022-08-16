using Command.Command.Business;
using Command.Command.Interface;

class Program
{
    static void Main(string[] args)
    {
        var commands = new List<ICommand>();

        commands.Add(new SaveCommand());
        commands.Add(new OpenCommand());

        foreach (var command in commands)
            command.Execute();
    }
}