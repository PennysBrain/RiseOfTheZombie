using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject gunOffSetLocation;
    public CameraShake camShake;
    public CharacterSystem characterSystem;
    public void CreateBullet()
    {
        characterSystem.animator.SetBool("isShooting", true);
        StartCoroutine( camShake.Shake(.15f,.4f));
        GameObject go = Instantiate(Bullet,gunOffSetLocation.transform.position,Quaternion.identity);
    }
}
