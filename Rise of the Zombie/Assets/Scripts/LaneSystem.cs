using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSystem : MonoBehaviour
{

    public GameObject[] lanes = new GameObject[3];
    public float currentLane;

    // Start is called before the first frame update
    void Start()
    {
        FreeLaneSpawn();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FreeLaneSpawn()
    {
        currentLane = Random.Range(0f,3f);
    }
}
