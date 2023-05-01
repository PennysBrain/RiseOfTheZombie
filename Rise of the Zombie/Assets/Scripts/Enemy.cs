using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);    
    }
}
