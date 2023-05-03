using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;

        if (transform.position.x >= 10)
        {
            this.gameObject.SetActive(false);
            GameManager.instance.zombieExcaped++;
            //zombieExcaped++;
        }
    }
}
