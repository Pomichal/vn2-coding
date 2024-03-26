using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerHealthSystem : HealthSystem
{

    public static UnityEvent onHealthChanged = new UnityEvent();

    public static PlayerHealthSystem instance;

    public override void Start()
    {
        base.Start();
        instance = this;
        onHealthChanged.Invoke();
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        onHealthChanged.Invoke();
    }


}
