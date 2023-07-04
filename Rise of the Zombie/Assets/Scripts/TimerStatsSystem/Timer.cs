using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time = 2f;
    float resetTime;
    public bool timeWasReset;

    private void Awake()
    {
        resetTime = time;
    }

    private void Update()
    {
        time = time -Time.deltaTime;
        if (time <= 0)
        {
            timeWasReset =  true;
            //Debug.Log("when off");
            time = resetTime;
        }
        else
        {
            timeWasReset =  false;
        }
    }
}
