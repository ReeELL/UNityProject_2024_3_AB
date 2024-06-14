using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private StateMachine statMachine;
    private float duration = 2.0f;
    private float timer;

    public IdleState(StateMachine statMachine)
    {
        this.statMachine = statMachine;
    }

    public void Enter()
    {
        Debug.Log("Entered Idle State");
        timer = 0f;
    }

    public void Execute()
    {
        timer += Time.deltaTime;
        if(timer >= duration)
        {
            statMachine.ChangeState(new PetrolState(statMachine));
        }
    }

    public void Exit()
    {
        Debug.Log("Entered Idle State");
    }
}
