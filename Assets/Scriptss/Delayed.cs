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
        if(timer > Time.time)
        {
            // explosion
            Explode();
            timer = 0f;
        }
    }

    public override void PlayerContacted()
    {
        timer = TimerHelper.GetDoneTime(explosionTime);
    }
}
