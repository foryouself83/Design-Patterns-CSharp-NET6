using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    public abstract class Participant
    {
        public string Name;
        protected bool isOn = false;
        protected IMediator mediator;

        public Participant(IMediator mediator, string name)
        {
            this.Name = name;
            this.mediator = mediator;
        }

        public override string ToString()
        {
            string state = isOn ? "On" : "Close";
            return $"{Name} {state}";
        }
    }
}
