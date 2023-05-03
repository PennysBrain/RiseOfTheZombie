using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject popEffect;
    private void Awake()
    {
        this.GetComponent<AudioSource>().pitch = Random.Range(-2.5f, 2.5f);
    }
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        Instantiate(popEffect,this.transform.position, Quaternion.identity);
        GameManager.instance.zombieCount++;
    }

    void OnEnable()
    {
       // this.GetComponent<AudioSource>().pitch = Random.Range(-2.5f, 2.5f);
        this.GetComponent<AudioSource>().PlayOneShot(this.GetComponent<AudioSource>().clip);
        //Debug.Log("PrintOnEnable: script was enabled");
    }

}
