using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFromList
{
    public static GameObject GetRandom(List<GameObject> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
