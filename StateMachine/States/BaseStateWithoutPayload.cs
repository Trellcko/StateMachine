namespace Trell.StateMachine
{
    public abstract class BaseStateWithoutPayload : BaseState, IEnter
    {
        protected BaseStateWithoutPayload(StateMachine machine) : base(machine)
        {

        }

        public virtual void Enter()
        {
        }

    }
}