using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.InputSystem.XR;

public class LightLaneColors : MonoBehaviour
{
    public Light[] eyesLight = new Light[2];

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("We change colors in at Start");

    }
}
