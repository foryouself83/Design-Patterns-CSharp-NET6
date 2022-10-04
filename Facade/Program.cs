using Facade.Business;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var facade = new FacadeSystem();
        facade.CreateStpaSystem();
        facade.Save("stpa.vsa");

        facade = new FacadeSystem();
        facade.CreateFtaSystem();
        facade.Save("fta.vsa");
    }

}