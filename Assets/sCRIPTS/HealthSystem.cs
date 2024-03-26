using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{

    public int maxHp = 100;

    public int currentHp;

    public virtual void Start()
    {
        Heal();
        EnemySpawner.onEnemySpawned.AddListener(Heal);
    }

    public virtual void TakeDamage(int damage)
    {
        currentHp -= damage;
        if(currentHp <= 0)
        {
            Debug.Log("dead");
        }
    }

    public void Heal()
    {
        currentHp = maxHp;
    }
}
