using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleExplosion : EnemyBase
{

    public float explosionRadius = 5f;

    public override void CharacterEntered()
    {
        Explode();
    }

    public void Explode()
    {
        // vytvori sferu a zisti, ake collidery su v dosahu
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider hitCollider in hitColliders)
        {
            if(IsCharacter(hitCollider.gameObject))
            {
                HealthSystem hp = hitCollider.gameObject.GetComponent<HealthSystem>();
                hp.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
