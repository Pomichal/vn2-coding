using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargingState : BaseState
{

    public override void EnterState(GameObject obj)
    {
        base.EnterState(obj);
        StateMachine sm = mainObject.GetComponent<StateMachine>();
        // smer na hráča
        mainObject.GetComponent<Rigidbody>()
            .AddForce(sm.targetDir * sm.chargeSpeed, ForceMode.Impulse);
        sm.ChangeState(new IdleState());
    }
}
