using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatsUI : MonoBehaviour
{
    public TextMeshProUGUI text;
    public PlayerStats stats;

    private void Start()
    {
        text = this.GetComponent<TextMeshProUGUI>();
        if (!stats)
            stats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    private void LateUpdate()
    {
        text.text = "Player HP: " + stats.healthPoints.ToString();
    }
}
