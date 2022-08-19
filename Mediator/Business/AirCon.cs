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
            base.OnStateChanged();
        }
        public void Off()
        {
            if (!isOn) return;

            isOn = false;
            base.OnStateChanged();
        }

        public bool IsOff() => !isOn;

    }
}
