using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{

    public static EnemySpawner inst;

    public static UnityEvent onEnemySpawned = new UnityEvent();

    // treba napojit v editore
    public List<BaseEnemy> enemies = new List<BaseEnemy>();

    void Start()
    {
        inst = this;
    }

    BaseEnemy GetRandomEnemy()
    {
        return enemies[Random.Range(0, enemies.Count)];
    }

    public void CreateEnemy()
    {
        BaseEnemy instance = Instantiate(GetRandomEnemy(), transform.position, Quaternion.identity);
        Debug.Log(instance.name);
        onEnemySpawned.Invoke();
    }
}
