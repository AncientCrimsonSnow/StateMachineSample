using StateMachinePackage.Runtime;
using StateMachinePackage.Runtime.Transitions.Conditions;
using StateMachinePackage.Runtime.Transitions.Wrapper;
using System;

namespace Assets.TestStates
{
    public class Start : State
    {
        TimeCondition _timeCondition;
        readonly FloatWrapper _contdownValue = new(1);

        public Start(
            State parent = null) : base(
                parent)
        {
        }

        public override void Init()
        {
            base.Init();

            _timeCondition = new TimeCondition(_contdownValue);
            CreateTransition(typeof(MidStart), _timeCondition);
        }
        public override void Enter()
        {
            base.Enter();
            _timeCondition.StartTimer();
        }
        public override void Exit() {
            base.Exit();
        }

        protected override Type GetType()
        {
            return typeof( Start );
        }
    }
}