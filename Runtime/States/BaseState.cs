using System;
using System.Collections.Generic;
using System.Linq;

namespace Trell.StateMachine
{
    public abstract class BaseState : IExcitable
    {
        private List<ITransition> _transitions = new();

        private bool _isTransitionOrderDirty = false;

        private StateMachine StateMachine { get; set; }

        protected BaseState(StateMachine machine)
        {
            StateMachine = machine;
            OrderTransitions();
        }

        public void CheckTransition()
        {
            if (_isTransitionOrderDirty)
            {
                OrderTransitions();
            }
            
            foreach (ITransition transition in _transitions)
            {
                transition.TryCondition();
            }
        }

        public virtual void Exit()
        {
        }

        protected void GoToState<T>(Func<bool> when, int priority = 0) where T : BaseStateWithoutPayload
        {
            _transitions.Add(new Transition(when, StateMachine.SetState<T>, priority));
            _isTransitionOrderDirty = true;
        }

        protected void GoToState<T>() where T : BaseStateWithoutPayload
        {
            StateMachine.SetState<T>();
        }

        protected void GoToState<T, TPayLoad>(Func<bool> when, TPayLoad payLoad, int priority = 0)
            where T : BaseStateWithPayLoad<TPayLoad>
        {
            _transitions.Add(new Transition(when, () => StateMachine.SetState<T, TPayLoad>(payLoad), priority));
            _isTransitionOrderDirty = true;
        }

        protected void GoToState<T, TPayLoad>(TPayLoad payLoad) where T : BaseStateWithPayLoad<TPayLoad>
        {
            StateMachine.SetState<T, TPayLoad>(payLoad);
        }

        private void OrderTransitions()
        {
            _transitions = _transitions.OrderByDescending(x => x.Priority).ToList();
            _isTransitionOrderDirty = false;
        }
    }
}