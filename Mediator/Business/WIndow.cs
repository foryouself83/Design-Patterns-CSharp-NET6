using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    internal class WIndow : Participant
    {
        private bool _isClosed = false;

        public WIndow(IMediator mediator) : base(mediator)
        {
        }

        public void Open()
        {
            if (!_isClosed) return;

            _isClosed = false;
            mediator.ParticipantChanged(this);
        }
        public void Close()
        {
            if (_isClosed) return;

            _isClosed = true;
            mediator.ParticipantChanged(this);
        }

        public bool IsClosed() => _isClosed;

        public override string ToString()
        {
            if (_isClosed) return "창문 닫힘";
            else return "창문 열림";
        }
    }
}
