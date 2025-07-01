using Trell.TwoDTestTask.Infrastructure.Service.Infrastructure;

namespace Trell.TwoDTestTask.Infrastructure.States
{
    public class EmptyState : BaseStateWithoutPayload
    {
        public EmptyState(StateMachine machine) : base(machine)
        {

        }
    }
}