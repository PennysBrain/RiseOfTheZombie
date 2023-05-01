using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSystem : MonoBehaviour
{
    public float spawnTimerReset;
    public GameObject[] lanes = new GameObject[3];
    public int currentLane;
    public Spawn spawn; 

    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        //FreeLaneSpawn();
        if (spawn == null)
        {
            spawn = this.GetComponent<Spawn>();
        }
        currentTime = spawnTimerReset;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime - Time.deltaTime;
        if (currentTime <= 0f)
        {
            FreeLaneSpawn();
            currentTime = spawnTimerReset;
        }
    }

    public void FreeLaneSpawn()
    {
        currentLane = Random.Range(0,3);
        int zombo = Random.Range(0, spawn.pool.Length);
        if (spawn.pool[zombo].gameObject.activeSelf== false)
        {
            spawn.pool[zombo].transform.position = lanes[currentLane].transform.position;
            spawn.pool[zombo].SetActive(true);
        }
        //lanes[currentLane].SetActive(!lanes[currentLane].activeSelf);
    }
}
