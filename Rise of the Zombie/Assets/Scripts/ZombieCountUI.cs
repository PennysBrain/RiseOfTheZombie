using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZombieCountUI : MonoBehaviour
{
    public TextMeshProUGUI text; 

    // Start is called before the first frame update
    void Awake()
    {
        text = this.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        text.text = "Zombie Count" + GameManager.instance.zombieCount.ToString();
    }
}
