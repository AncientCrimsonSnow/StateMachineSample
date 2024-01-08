using StateMachinePackage.Runtime;
using System;

namespace Assets.Game.Core.GameStateMachine.Implementation.States
{
    public class MidMid : State
    {
        public MidMid(
            State parent = null) : base(
                parent)
        {   
            
        }

        public override void Init()
        {
            base.Init();
            StateMachineManager.AddState(
                new MidMidStart(this),
                new MidMidEnd(this));
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
            return  typeof( MidMid );
        }
    }
}