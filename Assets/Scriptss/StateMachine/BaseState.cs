using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState
{

    public GameObject mainObject;

    public virtual void EnterState(GameObject obj)
    {
        mainObject = obj;
    }

    public virtual void UpdateState()
    {
        
    }

    public virtual void ExitState()
    {

    }
}
