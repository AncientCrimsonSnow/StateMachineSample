using StateMachinePackage.Runtime;
using System;

namespace Assets.TestStates
{
    public class MidMidStart : State
    {
        public MidMidStart(
            State parent = null) : base(
                parent)
        {   
            
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
            return  typeof( MidMidStart );
        }
    }
}