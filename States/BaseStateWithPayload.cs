using Trell.TwoDTestTask.Infrastructure.Service.Infrastructure;

namespace Trell.TwoDTestTask.Infrastructure.States
{
    public abstract class BaseStateWithPayLoad<TPayLoad> : BaseState
    {
        protected BaseStateWithPayLoad(StateMachine machine) : base(machine)
        {

        }

        public virtual void Enter(TPayLoad payLoad)
        {
        }
    }
}