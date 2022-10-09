using State.Model;

public class Program
{
    public static void Main(string[] args)
    {
        var context = new UserContext();

        context.Report();
        context.SetUserType(State.Enum.UserType.Fmea);
        context.Report();
        context.SetUserType(State.Enum.UserType.Fta);
        context.Report();
        context.SetUserType(State.Enum.UserType.Stpa);
        context.Report();
        context.SetUserType(State.Enum.UserType.Ultimate);
        context.Report();
    }
}