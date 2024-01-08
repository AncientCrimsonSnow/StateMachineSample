using StateMachinePackage.Runtime;
using System;

namespace Assets.Game.Core.GameStateMachine.Implementation.States
{
    public class End : State
    {
        public End(
            State parent = null) : base(
                parent)
        {   
            
        }

        public override void Init()
        {
            base.Init();
            StateMachineManager.AddState(
                new EndStart(this),
                new EndEnd(this));
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
            return  typeof( End );
        }
    }
}