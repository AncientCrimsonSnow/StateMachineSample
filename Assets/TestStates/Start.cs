using StateMachinePackage.Runtime;
using System;

namespace Assets.TestStates
{
    public class Start : State
    {
        public Start(
            State parent = null) : base(
                parent)
        {
        }

        public override void Init()
        {
            base.Init();
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
            return typeof( Start );
        }
    }
}