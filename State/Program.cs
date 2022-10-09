using State.Model;

public class Program
{
    public static void Main(string[] args)
    {
        // Change Guest User
        var context = new UserContext();
        context.Report();

        // Change FMEA User
        context.SetUserType(State.Enum.UserType.Fmea);
        context.Report();
        // Change FTA User
        context.SetUserType(State.Enum.UserType.Fta);
        context.Report();
        // Change STPA User
        context.SetUserType(State.Enum.UserType.Stpa);
        context.Report();
        // Change Ultimate User
        context.SetUserType(State.Enum.UserType.Ultimate);
        context.Report();
    }
}