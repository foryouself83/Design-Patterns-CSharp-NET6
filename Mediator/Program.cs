using Mediator.Mediator.Business;

class Program
{
    static void Main(string[] args)
    {
        SmartHome home = new SmartHome();

        home.Report();

        home.Door.Open();
        home.Report();

        home.Door.Close();
        home.Report();

        home.AirCon.On();
        home.Report();

        home.AirCon.Off();
        home.Report();

        home.Window.Close();
        home.Report();

        home.Window.Open();
        home.Report();
    }
}