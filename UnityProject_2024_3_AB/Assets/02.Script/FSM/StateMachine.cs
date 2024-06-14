using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    void Enter();

    void Execute();

    void Exit();

}

public class StateMachine : MonoBehaviour
{
    private IState currentState;

    private void Update()
    {
        currentState?.Execute();
    }

    public void ChangeState(IState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }
}
