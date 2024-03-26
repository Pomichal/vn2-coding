using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{


    public override void EnterState(GameObject obj)
    {
        base.EnterState(obj);
    }

    public override void UpdateState()
    {
        float scaleFactor = 1 + Mathf.Sin(Time.time) * 0.1f;
        mainObject.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }

    public override void ExitState()
    {
        mainObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
