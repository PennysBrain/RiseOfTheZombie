using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;

        if (transform.position.x >= 10)
        {
            this.gameObject.SetActive(false);
        }
    }
}
