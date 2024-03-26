using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack : StateBase
{

    public override void EnterState(Machine obj)
    {   
        base.EnterState(obj);

        stateMachine.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 100f);

        stateMachine.ChangeState(new StateIdle());
    }
}
