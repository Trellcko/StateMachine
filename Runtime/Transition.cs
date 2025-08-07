using System;

namespace Trell.StateMachine
{
    public class Transition : ITransition
    {
        public int Priority { get; }
        private readonly Func<bool> _condition;
        private readonly Action _changeStateAction;

        public Transition(Func<bool> condition, Action changeStateAction, int priority = 0)
        {
            _condition = condition;
            _changeStateAction = changeStateAction;
            Priority = priority;
        }
        
        public void TryCondition()
        {
            if (_condition())
            {
                _changeStateAction?.Invoke();
            }
        }
    }
}
