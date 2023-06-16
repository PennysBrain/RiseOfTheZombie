using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZombieCountUI : MonoBehaviour
{
    public TextMeshProUGUI text;

    private XPSystem xpSystem;

    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        xpSystem = FindObjectOfType<XPSystem>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        text.text = "Zombie Count: " + GameManager.instance.zombieCount.ToString();
    }

    // Call this method when a zombie is killed to add XP
    public void AddXPOnZombieKill()
    {
        xpSystem.AddXP(5);
    }
}
