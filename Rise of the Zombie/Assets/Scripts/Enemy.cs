using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public CameraShake cameraShake;
    public GameObject popEffect;
    private void Awake()
    {
        this.GetComponent<AudioSource>().pitch = Random.Range(-2.5f, 2.5f);
        cameraShake = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<CameraShake>();
        
    }
    private void OnMouseDown()
    {
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
        StartCoroutine(cameraShake.Shake(.15f,.8f));
        Instantiate(popEffect, this.transform.position, Quaternion.identity);
        GameManager.instance.zombieCount++;
        //new WaitForSeconds(45f);
        //this.gameObject.SetActive(false);
    }

}
