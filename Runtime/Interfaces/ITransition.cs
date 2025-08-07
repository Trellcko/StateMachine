namespace Trell.StateMachine
{
    public interface ITransition
    {
        void TryCondition();
        int Priority { get; }
    }
}