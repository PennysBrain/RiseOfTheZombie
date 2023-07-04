using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class UI_Cost : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    public OnClickMeetsConditionsIncreaseStat statCostData;

    private void Awake()
    {
        if (text == null)
        {
            text = this.GetComponent<TextMeshProUGUI>();
        }
    }

    private void LateUpdate()
    {
        text.text = statCostData.statCostDecrease.ToString("n2");
    }
}
