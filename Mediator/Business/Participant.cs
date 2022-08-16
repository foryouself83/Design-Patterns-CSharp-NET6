using Mediator.Mediator.Interface;

namespace Mediator.Mediator.Business
{
    public abstract class Participant
    {
        protected IMediator mediator;

        public Participant(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
