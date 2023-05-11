using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    public float healthPoints = 10;
    //public bool isPlaye

    void CheckIfDead()
    {
        if (healthPoints <= 0)
        {
            Debug.Log("Player Restart Inset Coin now");
        }
    }

    void AddHealth()
    {
        healthPoints++;
    }

    void AddHealth(float points)
    {
        healthPoints += points;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            AddHealth(-1);
            CheckIfDead();
        }
    }
}
