using Mediator.Mediator.Business;

namespace Mediator.Mediator.Interface
{
    public interface IMediator
    {
        void ParticipantChanged(Participant participant);
    }
}
