using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : StateBase
{

    public override void UpdateState()
    {
        float pulseParam = 1 + Mathf.Sin(Time.time) * 0.3f;
        stateMachine.gameObject.transform.localScale = new Vector3(pulseParam, pulseParam, pulseParam);
    }

    public override void ExitState()
    {
        stateMachine.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
