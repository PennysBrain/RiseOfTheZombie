using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject gunOffSetLocation;
    public CameraShake camShake;
    public CharacterSystem characterSystem;
    public float fireRate = 0.5f;
   // private bool canfire;
    private float timeBetweenShots;

    public void Shoot()
    {
        if (Time.time > timeBetweenShots)
        {
            CreateBullet();
        }
        
        
    }

    void CreateBullet()
    {
        timeBetweenShots = fireRate + Time.time;
        characterSystem.animator.SetBool("isShooting", true);
        StartCoroutine( camShake.Shake(.15f,.4f));
        GameObject go = Instantiate(Bullet,gunOffSetLocation.transform.position,Quaternion.identity);
        //characterSystem.animator.SetBool("isShooting", false);
    }
}
