namespace Trell.StateMachine
{
    public abstract class BaseStateWithPayLoad<TPayLoad> : BaseState, IEnter<TPayLoad>
    {
        protected BaseStateWithPayLoad(StateMachine machine) : base(machine)
        {

        }

        public virtual void Enter(TPayLoad payLoad)
        {
        }
    }
}