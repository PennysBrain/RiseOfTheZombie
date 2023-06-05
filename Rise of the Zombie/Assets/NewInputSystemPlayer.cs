using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class NewInputSystemPlayer : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float deadZone = 0.5f;
    //[SerializeField] float jumpForce = 300f;
    private Vector3 target = new Vector3(-3f, 0f, 0f);
    [SerializeField] GameObject weaponSystem;

    Vector2 movementXnY;
    Rigidbody2D rigiBody;

    private void Awake() => GetComponent<Rigidbody2D>();

	//transform.position += new Vector3(Time.deltaTime * speed * movementXnY.x, 0, 0); //Time.deltaTime * speed * movementXnY.x,0,0);
    private void Update() => transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    
	public void OnMove(InputValue value)
    {
        movementXnY = value.Get<Vector2>();
        Debug.Log(movementXnY.ToString());
        if (movementXnY.y >= deadZone)
        {
            if (transform.position.z != 3)
            {
                if (transform.position.z < 0)
                {
                    target.z = 0;
                }
                else
                    target.z = 1.5f;
            }
        }

        if(movementXnY.y <= (deadZone * -1))
        {
            if (transform.position.z != -3)
            {
                if (transform.position.z > 0)
                {
                    target.z = 0;
                }
                else
                    target.z = -6;
            }
        }
    }

    public void OnFire()
    {
        weaponSystem.GetComponent<FireButton>().Shoot();
    }


   
    //=> movementXnY = value.Get<Vector2>();
    //public void OnFire(InputValue value) => rigiBody.AddForce(Vector2.up * jumpForce);
}
