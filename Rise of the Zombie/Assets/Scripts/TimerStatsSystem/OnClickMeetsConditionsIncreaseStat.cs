using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickMeetsConditionsIncreaseStat : MonoBehaviour
{
    [SerializeField] Stat statToIncrease;
    [SerializeField] Stat statCheckMeetCondition;
    public int countIncrease = 1;
    public float statCostDecrease = 1;

    private void Awake()
    {
        for (int i = 0; i < statToIncrease.count; i++)
        {
            statCostDecrease = statCostDecrease + (statCostDecrease * 0.15f);
            Debug.Log(statCostDecrease );
        }

    }

    public void OnClickCheck()
    {
        Debug.Log("Checking if can spend");
        if (statCheckMeetCondition.count > statCostDecrease)
        {
            Debug.Log("You are big spender gradma");
            statCheckMeetCondition.count -= statCostDecrease;
            statToIncrease.count += countIncrease;
            statCostDecrease = statCostDecrease + (statCostDecrease * 0.15f);
        }
        else
        {
            Debug.Log("Grand gram you poor");
        }
    }
}
