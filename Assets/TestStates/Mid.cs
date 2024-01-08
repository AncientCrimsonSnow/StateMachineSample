using StateMachinePackage.Runtime;
using System;

namespace Assets.TestStates
{
    public class Mid : State
    {
        public Mid(
            State parent = null) : base(
                parent)
        {
        }

        public override void Init()
        {
            base.Init();
            StateMachineManager.AddState(
                new MidStart(this),
                new MidMid(this),
                new MidEnd(this));
        }
        public override void Enter()
        {
            base.Enter();
        }
        public override void Exit() {
            base.Exit();
        }

        protected override Type GetType()
        {
            return typeof(Mid);
        }
    }
}