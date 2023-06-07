using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public GameObject[] Bullet = new GameObject[2];
    [SerializeField] int currentWeaponBulletType; 
    public GameObject gunOffSetLocation;
    public CameraShake camShake;
    public CharacterSystem characterSystem;
    public float fireRate = 0.5f;
   // private bool canfire;
    private float timeBetweenShots;

    private void Start()
    {
        currentWeaponBulletType = this.GetComponent<WeapondSystem>().currentWeaponIndex;
    }

    public void Shoot()
    {
        if (Time.time > timeBetweenShots)
        {
            currentWeaponBulletType = this.GetComponent<WeapondSystem>().currentWeaponIndex;
            CreateBullet();
        }
        
        
    }

    void CreateBullet()
    {
        timeBetweenShots = fireRate + Time.time;
        characterSystem.animator.SetBool("isShooting", true);
        StartCoroutine( camShake.Shake(.15f,.4f));
        GameObject go = Instantiate(Bullet[currentWeaponBulletType],gunOffSetLocation.transform.position,Quaternion.identity);
        //characterSystem.animator.SetBool("isShooting", false);
    }
}
