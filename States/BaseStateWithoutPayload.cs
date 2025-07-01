using Trell.TwoDTestTask.Infrastructure.Service.Infrastructure;

namespace Trell.TwoDTestTask.Infrastructure.States
{
    public abstract class BaseStateWithoutPayload : BaseState
    {
        protected BaseStateWithoutPayload(StateMachine machine) : base(machine)
        {

        }

        public virtual void Enter()
        {
        }

    }
}