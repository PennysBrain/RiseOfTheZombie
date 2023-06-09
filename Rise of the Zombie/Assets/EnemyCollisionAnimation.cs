using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ZombieAnimationSystem))]
public class EnemyCollisionAnimation : MonoBehaviour
{
    ZombieAnimationSystem zombieAnimation;

    private void Start()
    {
        if (!zombieAnimation)
        {
            zombieAnimation = this.GetComponent<ZombieAnimationSystem>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ammo")
        {
            zombieAnimation.TakeAHit(true,collision.gameObject.GetComponent<BulletAI>().damage);
        }
    }

    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ammo")
        {
            zombieAnimation.TakeAHit(false);
            Debug.Log("WE LEFT THE BUILDING");
        }
    }
}
