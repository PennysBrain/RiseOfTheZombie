using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour
{
    public Spawn spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner.pool[0].SetActive(true);
    }

 /*   private void OnTriggerEnter(Collider other)
    {
        Spawn spawner = other.GetComponent<Spawn>();
        if (spawner == null)
        {
            Debug.Log("other.GetComponent returned null");
        }
        spawner.pool[0].SetActive(true);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
         spawner = other.GetComponent<Spawn>();
        if (spawner == null)
        {
            Debug.Log("other.GetComponent returned null");
        }
        spawner.pool[0].SetActive(true);
    }*/
}
