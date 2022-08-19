using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    internal class SmartHome : IMediator
    {
        public Door Door { get; private set; }
        public WIndow Window { get; private set; }
        public AirCon AirCon { get; private set; }

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
                        {
                            if (AirCon.IsOff())
                                Window.Open();
                        }
                    }
                    break;
                case WIndow window:
                    {
                        if (window.IsClosed())
                            AirCon.On();
                        else
                            AirCon.Off();
                    }
                    break;
                case AirCon airCon:
                    {
                        if (airCon.IsOff())
                            Window.Open();
                        else
                        {
                            Door.Close();
                            Window.Close();
                        }
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
