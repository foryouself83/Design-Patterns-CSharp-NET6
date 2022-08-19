using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    internal class Door : Participant
    {

        public Door(IMediator mediator) : base(mediator, nameof(Door))
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
