using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : ItemBase
{

    public override void Use()
    {
        base.Use();
        Debug.Log("increase hp");
    }
}
