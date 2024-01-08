﻿using StateMachinePackage.Runtime;
using System;

namespace Assets.TestStates
{
    public class MidMidEnd : State
    {
        public MidMidEnd(
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
            return  typeof( MidMidEnd );
        }
    }
}