using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public int damage = 10;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            // contact with the player
            PlayerContacted(other.gameObject);
        }
    }

    public virtual void PlayerContacted(GameObject p)
    {
        Debug.Log("contact with player");
    }
}
