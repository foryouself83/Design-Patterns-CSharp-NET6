using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    internal class SmartHome : IMediator
    {
        public Door Door;
        public WIndow Window;
        public AirCon AirCon;

        public SmartHome()
        {
            Door = new Door(this);
            Window = new WIndow(this);
            AirCon = new AirCon(this);
        }

        public void ParticipantChanged(Participant participant)
        {
            switch (participant)
            {
                case Door door:
                    {
                        if (door.IsClosed())
                            Window.Close();
                    }
                    break;
                case WIndow window:
                    {
                        if (window.IsClosed())
                            AirCon.On();
                    }
                    break;
                case AirCon airCon:
                    {
                        if (airCon.IsOff())
                            Window.Open();
                    }
                    break;
                default:
                    break;
            }
        }

        public void Report()
        {
            Console.WriteLine(Door.ToString());
            Console.WriteLine(Window.ToString());
            Console.WriteLine(AirCon.ToString());
            Console.WriteLine("");
        }
    }
}
