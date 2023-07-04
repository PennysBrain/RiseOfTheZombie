using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCountStat : MonoBehaviour
{
    [SerializeField] OnClickIncreaseStat clickStatRefrence;
    [SerializeField] Stat statRefrence;

    private void Awake()
    {
        if (clickStatRefrence != null) 
        {
            clickStatRefrence = this.GetComponent<OnClickIncreaseStat>();
        }
        clickStatRefrence.countIncrease = (int) statRefrence.count;
    }

    private void Update()
    {
        
    }
}
