﻿using StateMachinePackage.Runtime;
using System;

namespace Assets.TestStates
{
    public class MidEnd : State
    {
        public MidEnd(
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
            return  typeof( MidEnd );
        }
    }
}