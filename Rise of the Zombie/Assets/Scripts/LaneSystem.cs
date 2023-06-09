using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSystem : MonoBehaviour
{
    public float spawnTimerReset;
    public GameObject[] lanes = new GameObject[3];
    public Color[] laneColors = new Color[3]; 
    public int currentLane;
    public Spawn spawn; 

    public float currentTime;
    public float offSetSpawnSpeed = 2.0f;//Increase Zombie Speed Each new Spawn
    public float offSetSpawnTime = 0.5f;
    private float hardResetTime;

    // Start is called before the first frame update
    void Start()
    {
        //FreeLaneSpawn();
        if (spawn == null)
        {
            spawn = this.GetComponent<Spawn>();
        }
        currentTime = spawnTimerReset;
        hardResetTime = currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime - Time.deltaTime;
        if (currentTime <= 0f)
        {
            FreeLaneSpawn();
            currentTime = spawnTimerReset - offSetSpawnTime;
            spawnTimerReset = currentTime;
            Debug.Log(currentTime.ToString());
            if (currentTime <= offSetSpawnTime)
            {
                Debug.Log("ResetTimer");
                spawnTimerReset = hardResetTime;
            }
        }
    }

    public void FreeLaneSpawn()
    {
        currentLane = Random.Range(0,3);
        int zombo = Random.Range(0, spawn.pool.Length);//Get Random 

        if (spawn.pool[zombo].gameObject.activeSelf== false)
        {
            spawn.pool[zombo].transform.position = lanes[currentLane].transform.position;
            spawn.pool[zombo].GetComponent<ZombieAnimationSystem>().Run();
            spawn.pool[zombo].GetComponent<EnemyStats>().ResetStats();
            spawn.pool[zombo].GetComponent<ZombieAI>().speed += offSetSpawnSpeed;
            spawn.pool[zombo].GetComponent<LightLaneColors>().eyesLight[0].color = laneColors[currentLane];
            spawn.pool[zombo].GetComponent<LightLaneColors>().eyesLight[1].color = laneColors[currentLane];
            spawn.pool[zombo].SetActive(true);
            spawn.pool[zombo].GetComponent<FlashColor>().Flash();
            spawn.pool[zombo].GetComponent<ZombieAI>().wasHit = false;
        }
    }
}
