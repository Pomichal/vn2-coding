using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase
{
    public Machine stateMachine;

    public virtual void EnterState(Machine main)
    {
        stateMachine = main;
        // co treba setupnut na start
    }

    public virtual void UpdateState()
    {
        // co sa deje na update?
    }

    public virtual void ExitState()
    {
        // co sa deje na exit?
    }
}
