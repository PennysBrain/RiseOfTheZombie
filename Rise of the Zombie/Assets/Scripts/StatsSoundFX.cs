using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSoundFX : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] AudioSource gameSong;

    float max;
    float min;
    float current;

    private void Start()
    {
        if (playerStats == null)
        {
           playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        }
        if (!gameSong)
        {

        }

        max = playerStats.healthPoints;
        current = playerStats.healthPoints;
    }

    private void LateUpdate()
    {
        current = playerStats.healthPoints;

        if (current <= 1)
        {
            UpadateSound();
        }

    }

    void UpadateSound()
    {
        gameSong.pitch = 0.8f; //-= Mathf.Lerp(min, max, gameSong.pitch);
    }


}
