using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class carMovement : MonoBehaviour
{
    //Variables and References
    #region
    //Variables

    [SerializeField] private float movementSpeed;
    [SerializeField] private float sprintingSpeed;
    [SerializeField] private float turnSpeed;
    public bool canDock = false, isDocking = false;
    private Vector3 startingPosition, dockPosition;
    private Quaternion startingRotation, dockRotation;
    private float dockTimer = 0f;

    //References and Objects
    private InputActions inputActions;
    private CharacterController carController;
    public Transform characterStorage;

    public UnityEvent onExitCar;
    #endregion


    private void Awake()
    {
         
        carController = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (onExitCar == null)
        {
            onExitCar = new UnityEvent();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void Update()
    {
       
        //car Driving Movement
        Vector2 inputVector = inputActions.Car.Driving.ReadValue<Vector2>();
        Vector3 movementVector = transform.forward * Mathf.Clamp01(inputVector.y);
        float usedSpeed;
        if (inputActions.Car.Boost.IsPressed())
        {
            usedSpeed = sprintingSpeed;
        }
        else
        {
            usedSpeed = movementSpeed;
        }

        carController.Move(movementVector * usedSpeed * Time.deltaTime);
        carController.gameObject.transform.Rotate(Vector3.up, inputVector.x * turnSpeed * Time.deltaTime);


        //Entering Car
        if (inputActions.Car.ExitCar.IsPressed() && canDock)
        {
            isDocking = true;
            startingPosition = transform.position;
            startingRotation = transform.rotation;
        }

        if(isDocking)
        {
            dockTimer = Mathf.Clamp01(dockTimer += Time.deltaTime);
            transform.position = Vector3.Lerp(startingPosition, dockPosition, dockTimer);
            transform.rotation = Quaternion.Slerp(startingRotation, dockRotation, dockTimer);
            if(dockTimer == 1)
            {
                onExitCar.Invoke();
                dockTimer = 0;
                isDocking = false;
            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Dock")
        {
            canDock = true;
            dockPosition = other.transform.position;
            dockRotation = other.transform.rotation;
            dockPosition = new Vector3(dockPosition.x,transform.position.y, dockPosition.z);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Dock")
        {
            canDock = false;
        }
    }

    //InputActions
    public void enableCarControls()
    {
        inputActions.Car.Enable();
    }

    public void disableCarControls()
    {
        inputActions.Car.Disable(); 
    }

    private void OnEnable()
    {
        inputActions = new InputActions();
        inputActions.Enable();
        inputActions.Car.Disable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
