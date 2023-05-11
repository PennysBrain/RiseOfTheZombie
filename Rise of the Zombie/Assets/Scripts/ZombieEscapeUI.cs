using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZombieEscapeUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Start()
    {
        text = this.GetComponent<TextMeshProUGUI>();
    }

    private void LateUpdate()
    {
        text.text = "Escaped : " + GameManager.instance.zombieExcaped.ToString();
    }
}
