using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Image healthBar;
    public float healthPoints = 10f;

    // Update is called once per frame
    void Update()
    {
        if (healthPoints <= 0)
        {
            CheckIfDead();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Heal(1);
        }
    }

    public void TakeDamage(float damage)
    {
        healthPoints -= damage;
        healthBar.fillAmount = healthPoints / 10f;
        CheckIfDead();
    }

    public void Heal(float healingAmount)
    {
        healthPoints += healingAmount;
        healthPoints = Mathf.Clamp(healthPoints, 0, 10);
        healthBar.fillAmount = healthPoints / 10f;
    }

    //2D collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
            CheckIfDead();
        }
    }

    //3D collison

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
            CheckIfDead();
        }
    }

    private void CheckIfDead()
    {
        if (healthPoints <= -4)
        {
            Debug.Log("Player Restart Insert Coin now");
            SceneManager.LoadScene(0);
        }
    }
}
