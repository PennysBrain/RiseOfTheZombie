using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class FollowCamEnemy : MonoBehaviour
{
    [SerializeField] CinemachineTargetGroup m_TargetGroup;
    [SerializeField] Spawn spawnPool;

    

    private void Start()
    {
        for (int i = 0; i < spawnPool.pool.Length; i++)
        {
            m_TargetGroup.AddMember(spawnPool.pool[i].transform,1f,0f);
        }    
    }
}
