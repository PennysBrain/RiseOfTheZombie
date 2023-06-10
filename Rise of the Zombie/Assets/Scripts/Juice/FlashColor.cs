using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashColor : MonoBehaviour
{   
    [SerializeField] private Material flashMaterial;
    public float duration;

    private SpriteRenderer sprite;
    private Material originalMaterial;
    private Coroutine flashRoutine;

    private void Awake()
    {
        sprite = this.GetComponentInChildren<SpriteRenderer>();
        originalMaterial = sprite.material;
        // Flash();//Testing 
    }
    
    public void Flash()
    {
        // If the flashRoutine is not null, then it is currently running.
        if (flashRoutine != null)
        {
            // In this case, we should stop it first.
            // Multiple FlashRoutines the same time would cause bugs.
            StopCoroutine(flashRoutine);
        }
        //sprite.color = new Color(255,0,0);

        // Start the Coroutine, and store the reference for it.
        flashRoutine = StartCoroutine(FlashRoutine());
    }

    private IEnumerator FlashRoutine()
    {
        /*float elapse = 0.0f;

        while (elapse < duration)
        {
            sprite.material = flashMaterial;
            elapse += Time.deltaTime;

            Debug.Log("this is happening and resetig material");//OLD STYLE Runs over and over

            yield return null;
        }

        sprite.material = originalMaterial;
        */

        // Swap to the flashMaterial.
        sprite.material = flashMaterial;

        // Pause the execution of this function for "duration" seconds.
        yield return new WaitForSeconds(duration);

        // After the pause, swap back to the original material.
        sprite.material = originalMaterial;
        flashRoutine = null;
    }
}
