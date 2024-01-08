using StateMachinePackage.Runtime;
using System;

namespace Assets.TestStates
{
    public class EndStart : State
    {
        public EndStart(
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
            return  typeof( EndStart );
        }
    }
}