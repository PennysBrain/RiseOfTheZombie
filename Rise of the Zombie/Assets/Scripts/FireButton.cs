using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject gunOffSetLocation;
    public CameraShake camShake;
    public void CreateBullet()
    {
        StartCoroutine( camShake.Shake(.15f,.4f));
        GameObject go = Instantiate(Bullet,gunOffSetLocation.transform.position,Quaternion.identity);
       // go.transform.rotation.z = 270f;
    }
}
