using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : HealthSystem
{

    public static PlayerHealth instance;
    public static UnityEvent healthChanged = new UnityEvent();

    public override void Start()
    {
        base.Start();
        instance = this;    
        healthChanged.Invoke();
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        healthChanged.Invoke();
    }
}
