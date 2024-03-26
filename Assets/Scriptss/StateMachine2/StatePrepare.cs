using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePrepare : StateBase
{

    float waitTime = 3f;

    float timer = 0f;

    public override void EnterState(Machine obj)
    {
        base.EnterState(obj);
        timer = waitTime;
    }

    public override void UpdateState()
    {
        Debug.Log("Prepare");
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            stateMachine.ChangeState(new StateAttack());
        }
    }
}
