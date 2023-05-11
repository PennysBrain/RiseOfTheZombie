using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;
using UnityEngine;

public class Player : MonoBehaviour
{
    //sets the speed of movement
    private float speed = 20f;
    private Vector3 target = new Vector3(-3f, 0f, 0f);
    private Vector2 inputVector = new Vector2(0f, 0f); 

    // Update is called once per frame
    void Update()
    {
       float step = speed * Time.deltaTime;

        //Checks for keyinput 
        // Commented out code is for left to right movement
        // if (Input.GetKey(KeyCode.LeftArrow))
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // if(transform.position.x != 5)
            if (transform.position.z != 3)
            {
                // if(tranform.position.x <0)
                if (transform.position.z < 0)
                {
                    //target.x = 0;
                    target.z = 0;
                }
                else
                //target.x = 5;
                target.z = 3;
            }
        }

             //   if (Input.GetKey(KeyCode.RightArrow))
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // if(transform.position.x !=5)
            if (transform.position.z != -3)
            {
                // if(transform.position.x >0)
                if (transform.position.z > 0)
                {
                    //traget.x =0;
                    target.z = 0;
                }
                else
                //target.x = -5;
                target.z = -3;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
