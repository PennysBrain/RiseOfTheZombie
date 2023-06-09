using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField]
    public float healthPoints = 10;
    public bool isDead;
    float hpReset;

    private void Awake()
    {
        hpReset = healthPoints;
    }

    void CheckIfDead()
    {
        if (healthPoints <= 0)
        {
            Debug.Log("Enemy Died");
            isDead = true;
            
        }
    }

    void AddHealth()
    {
        healthPoints++;
    }

    public void AddHealth(float points)
    {
        healthPoints = healthPoints + points;
        CheckIfDead();
    }

    public void ResetStats()
    {
        healthPoints = hpReset;
        isDead = false;
    }
}
