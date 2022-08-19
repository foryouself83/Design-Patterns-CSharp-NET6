using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    public abstract class Participant
    {
        public string Name;
        protected bool isOn = false;
        private IMediator _mediator;

        public Participant(IMediator mediator, string name)
        {
            this.Name = name;
            this._mediator = mediator;
        }

        public override string ToString()
        {
            string state = isOn ? "On" : "Close";
            return $"{Name} {state}";
        }
        protected void OnStateChanged()
        {
            _mediator.ParticipantChanged(this);
        }
    }
}
