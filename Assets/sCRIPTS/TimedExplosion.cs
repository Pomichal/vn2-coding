using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedExplosion : SimpleExplosion
{

    public float explosionTime = 1.5f;


    float timer;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                Explode();
            }
        }
    }

    public override void CharacterEntered()
    {
        timer = explosionTime;
    }
}
