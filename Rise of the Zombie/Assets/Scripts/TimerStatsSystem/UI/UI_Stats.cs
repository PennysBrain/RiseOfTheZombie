using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class UI_Stats : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI text;
    public Stat statData;

    private void Awake()
    {
        if (text == null) 
        {
            text = this.GetComponent<TextMeshProUGUI>();
        }
    }

    private void LateUpdate()
    {
        text.text = statData.statsName + " " + statData.count.ToString("n0");
    }
}
