using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public int damage = 10;

    void OnCollisionEnter(Collision other)
    {
        if(IsCharacter(other.gameObject))
        {
            CharacterEntered();
        }
    }

    public virtual void CharacterEntered()
    {
        Debug.Log("someone entered!");        
    }

    public bool IsCharacter(GameObject other)
    {
        return other.CompareTag("Player") || other.CompareTag("Enemy");
    }
}
