using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimationSystem : MonoBehaviour
{
    public Animator animator;
    [SerializeField] PlayerStats stats;
    [SerializeField] WeapondSystem weaponds;//Needs optimized
    [SerializeField] int animationState;
    private int currentWeaponIndex = -1;

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
            SetMovement(true, -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            SetMovement(true, 1);           
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
            SetIdleState();
        }
        //Shooting
        if (Input.GetKey(KeyCode.Space))
        {
            SetShootState();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isShooting", false);
            animationState = 0;
        }

        //Death
        if (stats.healthPoints <= 0)
        {
            animator.SetBool("isDead", true);
            animationState = 4;
        }
    }

    public void SwitchAnimateState() 
    {
        switch (animationState)
        {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonometry!");
                break;
            case 4:
                print("Hello and good day!");
                break;
            case 3:
                print("Whadya want?");
                break;
            case 2:
                print("Grog SMASH!");
                break;
            case 1:
                print("Ulg, glib, Pblblblblb");
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }

    public void SetIdleState() 
    {
        animator.SetBool("isMoving", false);
        animator.SetFloat("moveForward", 0);
        animationState = 0;
    }

    public void SetMovement(bool isMoving, int movesState)
    {
        animator.SetBool("isMoving", isMoving);
        animator.SetFloat("moveForward", movesState);
        animationState = 1;
    }

    public void SetShootState()
    {
        animator.SetBool("isShooting", true);
        animationState = 3;
    }

    public void WeaponSwitch(int weaponCount)
    {
        if (weaponCount != currentWeaponIndex) // Check if the weapon is different from the current weapon
        {
            animationState = 2;
            animator.SetFloat("weaponHoldster", (weaponCount + 1));
            animator.SetTrigger("weaponSwitch");
            weaponds.currentWeaponIndex = weaponCount;
            weaponds.ChangeWeapon();
            currentWeaponIndex = weaponCount; // Update the current weapon index
        }
    }
}