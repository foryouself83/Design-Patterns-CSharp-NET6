using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    internal class AirCon : Participant
    {
        private bool _isOff = true;

        public AirCon(IMediator mediator) : base(mediator)
        {
        }

        public void On()
        {
            if (!_isOff) return;

            _isOff = false;
            mediator.ParticipantChanged(this);
        }
        public void Off()
        {
            if (_isOff) return;

            _isOff = true;
            mediator.ParticipantChanged(this);
        }

        public bool IsOff() => _isOff;

        public override string ToString()
        {
            if (_isOff) return "에어컨 꺼짐";
            else return "에어컨 켜짐";
        }
    }
}
