using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public int price;

    public int rarity;

    public virtual void Use()
    {
        Debug.Log("item used");
    }
}
