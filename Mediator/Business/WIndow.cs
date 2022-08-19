using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    internal class WIndow : Participant
    {
        public WIndow(IMediator mediator) : base(mediator, nameof(WIndow))
        {
        }

        public void Open()
        {
            if (isOn) return;

            isOn = true;
            mediator.ParticipantChanged(this);
        }
        public void Close()
        {
            if (!isOn) return;

            isOn = false;
            mediator.ParticipantChanged(this);
        }

        public bool IsClosed() => !isOn;
    }
}
