using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareState : BaseState
{

    float timer = 0f;

    public override void EnterState(GameObject obj)
    {
        base.EnterState(obj);
        timer = mainObject.GetComponent<StateMachine>().waitTime;
    }

    public override void UpdateState()
    {
        mainObject.transform.rotation = Quaternion.Euler(0, Mathf.Sin(Time.time*3)*50, 0);
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            mainObject.GetComponent<StateMachine>().ChangeState(new ChargingState());
        }
    }

}
