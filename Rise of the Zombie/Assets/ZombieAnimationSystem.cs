using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ZombieAnimationSystem : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] EnemyStats stats;
    [SerializeField] ZombieAI zomboAI;

    // Start is called before the first frame update
    void Start()
    {
        if (!animator)
        {
            animator = this.GetComponent<Animator>();
        }
        if (!animator)
        {
            animator = this.GetComponentInChildren<Animator>();
        }

        if (!stats)
        {
            stats = this.GetComponent<EnemyStats>();
        }
        if (!zomboAI)
        { 
            zomboAI = this.GetComponent<ZombieAI>();
        }

        Run();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeAHit(bool gotHit) 
    {
        zomboAI.wasHit = gotHit;
        animator.SetBool("hurt",gotHit);
        
        //Check if Enemy is Dead
        if (stats.isDead)
        {
            Dead();
        }              
    }

    public void TakeAHit(bool gotHit,float recoilDamage)
    {
        zomboAI.wasHit = gotHit;
        zomboAI.recoilForHit = recoilDamage;
        animator.SetBool("hurt", gotHit);

        //Check if Enemy is Dead
        if (stats.isDead)
        {
            Dead();
        }
    }

    public void Attack() 
    {
    
    }

    public void Run() 
    {
        animator.SetBool("running", true);
    }

    public void Dead() 
    {
        animator.SetInteger("health", 0);
    }
}
