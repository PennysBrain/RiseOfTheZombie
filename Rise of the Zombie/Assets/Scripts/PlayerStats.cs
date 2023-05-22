using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    public float healthPoints = 10;
    //public bool isPlaye

    void CheckIfDead()
    {
        if (healthPoints <= -4)
        {
            Debug.Log("Player Restart Inset Coin now");           
            SceneManager.LoadScene(0);
        }
    }

    void AddHealth()
    {
        healthPoints++;
    }

    void AddHealth(float points)
    {
        healthPoints += points;
        CheckIfDead();
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
