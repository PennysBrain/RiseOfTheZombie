using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CameraShake cameraShake;
    public GameObject popEffect;
    public EnemyStats enemyStats;

    private void Start()
    {
        this.GetComponent<AudioSource>().pitch = Random.Range(-2.5f, 2.5f);
        cameraShake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
        enemyStats = this.GetComponent<EnemyStats>();
    }

    private void OnMouseDown()
    {
        enemyStats.AddHealth(-1);
        PopEffect();
    }

    void OnEnable()
    {
        // this.GetComponent<AudioSource>().pitch = Random.Range(-2.5f, 2.5f);
        this.GetComponent<AudioSource>().PlayOneShot(this.GetComponent<AudioSource>().clip);
        //Debug.Log("PrintOnEnable: script was enabled");
    }

    public void PopEffect()
    {
        StartCoroutine(cameraShake.Shake(.15f, .8f));
        Instantiate(popEffect, this.transform.position, Quaternion.identity);

        if (enemyStats.isDead == true)
        {
            GameManager.instance.ZombieKilled();
            this.gameObject.SetActive(false);
        }

        //new WaitForSeconds(45f);
        //
    }
}
