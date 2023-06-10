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
    [SerializeField] GameObject weaponSystem;
    [SerializeField] ControlAnimationSystem controlAnimationSystem;
    [SerializeField] float timerShootAnimation = 0.5f;
    [SerializeField] float timerMovementAnimation = 0.5f;

    

    [SerializeField] Vector3[] targetPositions = { new Vector3(0f, 0.2f, 0f), new Vector3(0f, 0.2f, -3f), new Vector3(0f, 0.2f, -6f) };
    private int currentTargetIndex = 0;
    private Vector2 movementXnY;
    private Vector2 rightStickMovement;
    float resetTimerShootAnimation;
    float resetMovementAnimation;


    private void Awake()
    {
        resetMovementAnimation = timerMovementAnimation;
        resetTimerShootAnimation = timerShootAnimation;
    }

    private void Update()
    {
        // Move the player towards the current target position
        transform.position = Vector3.MoveTowards(transform.position, targetPositions[currentTargetIndex], speed * Time.deltaTime);
        
        if (transform.position.z == targetPositions[currentTargetIndex].z && controlAnimationSystem.animator.GetBool("isMoving"))
        {
            //controlAnimationSystem.SetIdleState();
           controlAnimationSystem.SetMovement(false, 0);//IDle
            Debug.Log("WE HAVE ARRIVED");
        }

        if ((resetTimerShootAnimation + 1) > timerShootAnimation && timerShootAnimation <= 0)
        {
            timerShootAnimation -= Time.deltaTime;
        }
        else 
        {
            timerShootAnimation -= Time.deltaTime;
            if (timerShootAnimation <= 0)
                controlAnimationSystem.animator.SetBool("isShooting",false); //Reset Shooting
        }

    }

    public void OnMove(InputValue value)
    {
        // Get the joystick input value
        movementXnY = value.Get<Vector2>();

        // Check the y-axis value to determine the movement direction
        if (movementXnY.y >= deadZoneLeftStick)
        {
            MoveDown(); // Move the player down to the lower lane
        }
        else if (movementXnY.y <= -deadZoneLeftStick)
        {
            MoveUp(); // Move the player up to the higher lane
        }
        else
        {
            MoveToNearestLane(); // Move the player to the nearest lane when in the dead zone
        }
    }

    private void MoveUp()
    {
        controlAnimationSystem.SetMovement(true, 1);
        // Move the player up to the higher lane if possible
        if (currentTargetIndex < targetPositions.Length - 1)
        {
            currentTargetIndex++;
        }
    }

    private void MoveDown()
    {
        controlAnimationSystem.SetMovement(true, -1);
        // Move the player down to the lower lane if possible
        if (currentTargetIndex > 0)
        {
            currentTargetIndex--;
        }
    }

    private void MoveToNearestLane()
    {
        // Calculate the distance to each lane and move the player to the nearest one

        // Calculate the distance to the top lane (index 0)
        float distanceToTop = Mathf.Abs(transform.position.z);

        // Calculate the distance to the middle lane (index 1)
        float distanceToMiddle = Mathf.Abs(transform.position.z + 3f);

        // Calculate the distance to the bottom lane (index 2)
        float distanceToBottom = Mathf.Abs(transform.position.z + 6f);

        // Check which lane is the nearest and set the current target index accordingly
        if (distanceToTop < distanceToMiddle && distanceToTop < distanceToBottom)
        {
            currentTargetIndex = 0; // Set the target index to the top lane
        }
        else if (distanceToMiddle < distanceToTop && distanceToMiddle < distanceToBottom)
        {
            currentTargetIndex = 1; // Set the target index to the middle lane
        }
        else
        {
            currentTargetIndex = 2; // Set the target index to the bottom lane
        }
    }

    public void OnFire()
    {
        controlAnimationSystem.SetShootState();
        weaponSystem.GetComponent<FireButton>().Shoot();
        timerShootAnimation = resetTimerShootAnimation;
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
