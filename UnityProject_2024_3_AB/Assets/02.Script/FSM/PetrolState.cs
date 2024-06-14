using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetrolState : IState
{
    private StateMachine statMachine;
    private float duration = 2.0f;
    private float timer;

    public PetrolState(StateMachine statMachine)
    {
        this.statMachine = statMachine;
    }

    public void Enter()
    {
        Debug.Log("Entered Petrol State");
        timer = 0f;
    }

    public void Execute()
    {
        timer += Time.deltaTime;
        if (timer >= duration)
        {
            statMachine.ChangeState(new ChaseState(statMachine));
        }
    }

    public void Exit()
    {
        Debug.Log("Entered Petrol State");
    }
}
