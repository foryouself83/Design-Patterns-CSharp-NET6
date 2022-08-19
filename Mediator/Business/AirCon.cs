using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    internal class AirCon : Participant
    {
        public AirCon(IMediator mediator) : base(mediator, nameof(AirCon))
        {
        }

        public void On()
        {
            if (isOn) return;

            isOn = true;
            mediator.ParticipantChanged(this);
        }
        public void Off()
        {
            if (!isOn) return;

            isOn = false;
            mediator.ParticipantChanged(this);
        }

        public bool IsOff() => !isOn;

    }
}
