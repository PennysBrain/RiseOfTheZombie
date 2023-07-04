using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]

public class UI_TamalesPerSecon : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] List<Modifier> modifiersTPerSeconds;
    float tps;
    

    private void Awake()
    {
        if (text == null)
        {
            text = this.GetComponent<TextMeshProUGUI>();
        }
    }

    private void LateUpdate()
    {
        tps = 0;
        foreach (Modifier modifier in modifiersTPerSeconds) 
        {
            tps = tps + (modifier.countIncrease * modifier.multiply);
        }

        text.text = tps.ToString("n1") + " = TPS";
    }
}
