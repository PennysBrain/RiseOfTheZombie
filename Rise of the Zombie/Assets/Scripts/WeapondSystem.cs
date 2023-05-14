using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapondSystem : MonoBehaviour
{
    int weaponTotal = 1;
    [SerializeField]public int currentWeaponIndex;

    public GameObject[] guns;
    public GameObject weapondHolder;
    public GameObject currentGun;

    // Start is called before the first frame update
    void Start()
    {
        weaponTotal = weapondHolder.transform.childCount;
        guns = new GameObject[weaponTotal];

        for (int i = 0; i < weaponTotal; i++)
        {
            guns[i] = weapondHolder.transform.GetChild(i).gameObject;
            guns[i].SetActive(false);
        }

        //Set Default Gun
        guns[0].SetActive(true);
        currentGun = guns[0];
        currentWeaponIndex = 0;
    }

    public void ChangeWeapon()
    {
        //guns[currentWeaponIndex].SetActive(true);
        for (int i = 0; i < weaponTotal; i++)
        {
            guns[i] = weapondHolder.transform.GetChild(i).gameObject;
            guns[i].SetActive(false);
        }

        guns[currentWeaponIndex].SetActive(true);
        currentGun = guns[currentWeaponIndex];
        //currentWeaponIndex = 0;
        // currentGun = guns[0];
        // currentWeaponIndex = 0;
    }
}
