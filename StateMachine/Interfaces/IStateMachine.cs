namespace Trell.StateMachine
{
    public interface IStateMachine
    {
        void AddState(params BaseState[] states);
        void Update();
        void SetState<T>() where T : BaseStateWithoutPayload;
        void SetState<T, TPayload>(TPayload payload) where T : BaseStateWithPayLoad<TPayload>;
    }
}