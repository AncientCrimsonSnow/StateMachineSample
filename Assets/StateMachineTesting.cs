using Assets.Game.Core.GameStateMachine.Implementation.States;
using StateMachinePackage.Runtime;
using StateMachinePackage.Runtime.Transitions.Conditions;
using System;
using UnityEngine;

namespace Assets.Game.Core.GameStateMachine.Testing
{
    public class StateMachineTesting : MonoBehaviour
    {
        [SerializeField]
        private StateMachineManagerMono _smMono;

        private StateMachineManager _stateMachineManager;

        private Action _onLeftMouseClick = () => { };
        private Action _onRightMouseClick = () => { };

        private void Awake()
        {
            _smMono = GetComponent<StateMachineManagerMono>();
            _stateMachineManager = _smMono.StateMachineManager;

            _stateMachineManager.AddState(
                new Start(),
                new Mid(),
                new End());

            var leftMouseButtonClickCondition = new EventCondition(ref _onLeftMouseClick);
            var rightMouseButtonClickCondition = new EventCondition(ref _onRightMouseClick);

            _stateMachineManager.AddTransition(typeof(Start), typeof(MidStart), leftMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(MidStart), typeof(MidMidStart), leftMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(MidMidStart), typeof(MidMidEnd), leftMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(MidMidEnd), typeof(MidEnd), leftMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(MidEnd), typeof(EndStart), leftMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(EndStart), typeof(EndEnd), leftMouseButtonClickCondition);

            _stateMachineManager.AddTransition(typeof(MidStart), typeof(Start), rightMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(MidMidStart), typeof(MidStart), rightMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(MidMidEnd), typeof(MidMidStart), rightMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(MidEnd), typeof(MidMidEnd), rightMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(EndStart), typeof(MidEnd), rightMouseButtonClickCondition);
            _stateMachineManager.AddTransition(typeof(EndEnd), typeof(EndStart), rightMouseButtonClickCondition);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                _onLeftMouseClick.Invoke();
            if (Input.GetMouseButtonDown(1))
                _onRightMouseClick.Invoke();
        }
    }
}