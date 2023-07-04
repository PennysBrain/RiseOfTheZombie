using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickIncreaseStat : MonoBehaviour
{
    [SerializeField] Stat statToIncrease;
    public int countIncrease = 1;

    public void OnClick()
    {
        Debug.Log("button click");
        statToIncrease.count += countIncrease;
    }
}
