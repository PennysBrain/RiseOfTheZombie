using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class NewInputSystemPlayer : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float deadZoneLeftStick = 0.5f;
    [SerializeField] float deadZoneRightStick = 0.2f;
    private Vector3 target = new Vector3(-3f, 0f, 0f);
    [SerializeField] GameObject weaponSystem;
    [SerializeField] ControlAnimationSystem controlAnimationSystem;

    Vector2 movementXnY;
    Vector2 rightStickMovement;

    private void Update() => transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    
	public void OnMove(InputValue value)
    {
        movementXnY = value.Get<Vector2>();
        Debug.Log(movementXnY.ToString());
        if (movementXnY.y >= deadZoneLeftStick)
        {
            if (transform.position.z != 3)
            {
                if (transform.position.z < 0)
                {
                    target.z = 0;
                }
                else
                    target.z = 0;
            }
        }

        if(movementXnY.y <= (deadZoneLeftStick * -1))
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

    public void OnLook(InputValue value)
    {
        rightStickMovement = value.Get<Vector2>();

        if (rightStickMovement.y >= deadZoneRightStick)
        {
            controlAnimationSystem.WeaponSwitch(0);
        }
        if (rightStickMovement.y <= (deadZoneRightStick * -1))
        {
            controlAnimationSystem.WeaponSwitch(1);
        }
    }
}
