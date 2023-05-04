using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject gunOffSetLocation;
    public void CreateBullet()
    {
        Instantiate(Bullet,gunOffSetLocation.transform.position,Quaternion.identity);
    }
}
