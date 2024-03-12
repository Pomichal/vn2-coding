using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{

    public GameObject attackArea;

    public float attackDuration = 1.0f;
    float attackTimer;

    void Start()
    {
        attackArea.SetActive(false);
    }

    void Update()
    {
        if(attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
            if(attackTimer <= 0)
            {
                attackArea.SetActive(false);
            }
        }
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            attackArea.SetActive(true);
            attackTimer = attackDuration;
        }
    }
}
