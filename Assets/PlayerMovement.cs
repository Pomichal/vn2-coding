using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    Rigidbody rb;
    Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 horizontalMovement = new Vector3(movementDirection.x, 0, movementDirection.y) * moveSpeed;
        rb.velocity = new Vector3(horizontalMovement.x, rb.velocity.y, horizontalMovement.z);

    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }
}
