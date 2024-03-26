using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{

    // premenne ovplyvnujuce spravanie sa
    public float waitTime = 2f;
    public float chargeSpeed = 5f;
    public Vector3 targetDir;

    BaseState activeState;

    // Start is called before the first frame update
    void Start()
    {
        // new vytvori novu instanciu danej triedy
        // (ale nie gameobject, iba samotny script)
        // podobne funguje napr new Vector3()
        ChangeState(new IdleState());
    }

    // Update is called once per frame
    void Update()
    {
        activeState.UpdateState();
    }

    public void ChangeState(BaseState newState)
    {
        if(activeState != null)
        {
            activeState.ExitState();
        }
        activeState = newState;
        activeState.EnterState(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // ziskam smer na hraca
            // normalized -> nastavi dlzku vektora na 1
            targetDir = (other.transform.position - transform.position).normalized;
            ChangeState(new PrepareState());
        }
    }
}
