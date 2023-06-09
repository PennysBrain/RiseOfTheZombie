using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAI : MonoBehaviour
{
    public float speed = 4.20f;
    public float damage =1f;

    // Update is called once per frame
    void Update()
    {
        transform.position +=  Time.deltaTime * speed * transform.right ;
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
            collision.gameObject.GetComponent<FlashColor>().Flash();
            collision.gameObject.GetComponent<EnemyStats>().AddHealth(-damage);
            collision.gameObject.GetComponent<Enemy>().PopEffect();
            //GameObject go = collision.gameObject.GetComponent<Enemy>().popEffect;
           // Instantiate(go,this.transform.position,Quaternion.identity);
           // GameManager.instance.zombieCount++;
            //collision.gameObject.SetActive(false);
            // Destroy(collision.gameObject);
            //Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Add Resources HERE for Zombie and Fix FX");
            collision.gameObject.GetComponent<FlashColor>().Flash();
            collision.gameObject.GetComponent<EnemyStats>().AddHealth(-damage);
            collision.gameObject.GetComponent<Enemy>().PopEffect();
            this.GetComponent<SpriteRenderer>().enabled = false;
           // this.GetComponent<ZombieAI>().recoilForHit = damage;
            //GameObject go = collision.gameObject.GetComponent<Enemy>().popEffect;
            // Instantiate(go,this.transform.position,Quaternion.identity);
            // GameManager.instance.zombieCount++;
            //collision.gameObject.SetActive(false);
            // Destroy(collision.gameObject);
            //Destroy(this.gameObject);
        }
    }
}
