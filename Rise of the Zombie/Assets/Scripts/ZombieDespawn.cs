using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDespawn : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
