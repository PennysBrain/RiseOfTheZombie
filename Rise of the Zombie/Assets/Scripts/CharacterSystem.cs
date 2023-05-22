using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSystem : MonoBehaviour
{
    public Animator animator;
    [SerializeField] PlayerStats stats;

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
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isMoving",true);
            animator.SetFloat("moveForward", -1);
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isMoving", true);
            animator.SetFloat("moveForward", 1);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isMoving", false);
            animator.SetFloat("moveForward", 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isShooting", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isShooting", false);
        }

        if (stats.healthPoints <= 0)
        {
            animator.SetBool("isDead", true);
        }
    }
}
