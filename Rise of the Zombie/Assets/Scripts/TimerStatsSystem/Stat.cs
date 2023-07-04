using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Stat : MonoBehaviour
{
    public bool safeTheStat;
    public string statsName;
    public float count;

    private void OnEnable()
    {
        if (safeTheStat)
        {
           count = PlayerPrefs.GetFloat(statsName);
            Debug.Log("LOAD");
        }
    }
    private void OnDisable()
    {
        if (safeTheStat)
        {
            PlayerPrefs.SetFloat(statsName, count);
            Debug.Log("SAVED");

        }
    }
}
