using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public GameObject Bullet;
    public void CreateBullet()
    {
        Instantiate(Bullet);
    }
}
