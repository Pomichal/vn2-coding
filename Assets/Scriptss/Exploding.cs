using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploding : BaseEnemy
{

    public override void PlayerContacted(GameObject p)
    {
        // damage to the player
        HealthSystem hp = p.GetComponent<HealthSystem>();
        hp.TakeDamage(damage);

        Destroy(gameObject);
    }
}
