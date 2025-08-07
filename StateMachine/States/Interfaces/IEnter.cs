namespace Trell.StateMachine
{
    public interface IEnter<in T>
    {
        void Enter(T payload);
    }

    public interface IEnter
    {
        void Enter();
    }
}