using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delayed : Exploding
{

    public float explosionTime = 1.5f;
    float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                // explosion
                Explode();
            }
        }
    }

    public override void PlayerContacted()
    {
        timer = explosionTime;
    }
}
