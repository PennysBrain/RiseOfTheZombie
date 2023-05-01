using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Awake()
    {
        this.GetComponent<AudioSource>().pitch = Random.Range(-2.5f, 2.5f);
    }
    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);    
    }

    void OnEnable()
    {
       // this.GetComponent<AudioSource>().pitch = Random.Range(-2.5f, 2.5f);
        this.GetComponent<AudioSource>().Play();
        //Debug.Log("PrintOnEnable: script was enabled");
    }

}
