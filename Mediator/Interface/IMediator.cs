using Mediator.Mediator.Business;

namespace Mediator.Mediator.Interface
{
    public interface IMediator
    {
        /// <summary>
        /// Action 후 호출되어
        /// </summary>
        /// <param name="participant"></param>
        void ParticipantChanged(Participant participant);
    }
}
