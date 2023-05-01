using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject poolType;   
    public GameObject[] pool = new GameObject[5];
    // Start is called before the first frame update
    void Awake()
    {
        FillPool(); 
    }

    void FillPool() 
    {
        for (int i = 0; i < pool.Length; i++)
        {
            GameObject go = GameObject.Instantiate( poolType);
            go.SetActive(false);
            pool[i] = go;
        }
    }
}
