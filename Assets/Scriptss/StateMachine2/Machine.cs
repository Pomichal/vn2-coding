using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public StateBase currentState;

    public void Start()
    {
        ChangeState(new StateIdle());
    }

    public void Update()
    {
        currentState.UpdateState();
    }

    public void ChangeState(StateBase newState)
    {
        if (currentState!= null)
        {
            currentState.ExitState();
        }
        currentState = newState;
        currentState.EnterState(this);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ChangeState(new StatePrepare());
        }
    }
}
