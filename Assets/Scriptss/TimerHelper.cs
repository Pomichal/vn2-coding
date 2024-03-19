using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerHelper
{

    public static float GetDoneTime(float duration)
    {
        return Time.time + duration;
    }
}
