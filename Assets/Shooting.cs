using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{

    public Rigidbody bullet;

    public void Shoot(InputAction.CallbackContext context)
    {
        Rigidbody bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
        bulletInstance.velocity = transform.forward * 10f;
        EnemySpawner.inst.CreateEnemy();
    }
}
