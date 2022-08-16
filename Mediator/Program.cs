using Mediator.Mediator.Business;

class Program
{
    static void Main(string[] args)
    {
        SmartHome home = new SmartHome();

        home.Door.Open();
        home.Report();

        home.Door.Close();
        home.Report();

        home.AirCon.Off();
        home.Report();

        home.Window.Close();
        home.Report();
    }
}