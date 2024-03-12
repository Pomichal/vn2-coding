using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploding : BaseEnemy
{

    public float explosionRadius = 3f;
    public override void PlayerContacted()
    {
        Explode();
    }

    public void Explode()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in hitColliders)
        {
            if(IsDamageable(collider.gameObject))
            {
                HealthSystem hp = collider.gameObject.GetComponent<HealthSystem>();
                hp.TakeDamage(damage);
                Debug.Log("damage everyone");
            }
        }
        Destroy(gameObject);
    }
}
