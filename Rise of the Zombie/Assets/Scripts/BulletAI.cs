using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAI : MonoBehaviour
{
    public float speed = 4.20f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Add Resources HERE for Zombie and Fix FX");
            GameObject go = collision.gameObject.GetComponent<Enemy>().popEffect;
            Instantiate(go);
            GameManager.instance.zombieCount++;
            collision.gameObject.SetActive(false);
            // Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
