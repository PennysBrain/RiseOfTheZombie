using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public float speed;
    public bool wasHit;
    public float recoilForHit = 2.0f; 
    // Update is called once per frame
    void Update()
    {
        if (wasHit)
        {
            transform.position += Time.deltaTime * speed * recoilForHit * transform.right;
        }

        if (!wasHit) 
        {
            transform.position -= Time.deltaTime * speed * transform.right;

            if (transform.position.x <= -10)
            {
                this.gameObject.SetActive(false);
                GameManager.instance.zombieExcaped++;
                //zombieExcaped++;
            }
        }

       


    }
}
