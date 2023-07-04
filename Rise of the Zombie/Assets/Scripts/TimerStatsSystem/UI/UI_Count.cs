using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class UI_Count : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
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
        text.text = statData.count.ToString("n0");
    }
}
