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
            base.OnStateChanged();
        }
        public void Close()
        {
            if (!isOn) return;

            isOn = false;
            base.OnStateChanged();
        }

        public bool IsClosed() => !isOn;



    }
}
