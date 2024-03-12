using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public int damage = 10;

    void OnCollisionEnter(Collision other)
    {
        if(IsDamageable(other.gameObject))
        {
            // contact with the player
            PlayerContacted();
        }
    }

    public virtual void PlayerContacted()
    {
        Debug.Log("contact with player");
    }

    public bool IsDamageable(GameObject o)
    {
        return o.CompareTag("Player") || o.CompareTag("Enemy");
    }
}
