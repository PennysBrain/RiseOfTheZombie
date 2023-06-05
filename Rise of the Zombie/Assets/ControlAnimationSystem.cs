using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimationSystem : MonoBehaviour
{
    public Animator animator;
    [SerializeField] PlayerStats stats;
    [SerializeField] WeapondSystem weaponds;//Needs optimized

    private void Start()
    {
        if (!animator)
        {
            animator = this.GetComponent<Animator>();
        }

        if (!stats)
        {
            stats = this.GetComponent<PlayerStats>();
        }
    }

    private void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isMoving", true);
            animator.SetFloat("moveForward", -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isMoving", true);
            animator.SetFloat("moveForward", 1);
        }

        //Switch Weaponds
        if (Input.GetKeyUp(KeyCode.Q))//Dual gun
        {
            WeaponSwitch(0);
        }

        if (Input.GetKeyUp(KeyCode.E))//Rifle
        {
            WeaponSwitch(1);
        }


        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isMoving", false);
            animator.SetFloat("moveForward", 0);
        }
        //Shooting
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isShooting", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isShooting", false);
        }

        //Death
        if (stats.healthPoints <= 0)
        {
            animator.SetBool("isDead", true);
        }
    }

    public void WeaponSwitch(int weaponCount)
    {
        animator.SetFloat("weaponHoldster", (weaponCount + 1));
        animator.SetTrigger("weaponSwitch");
        weaponds.currentWeaponIndex = weaponCount;
        weaponds.ChangeWeapon();
    }
}