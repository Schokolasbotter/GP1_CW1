using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables and References
    #region
    //Variables
    [Header("Variables",order=0)]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float sprintingSpeed;
    [SerializeField] private float aimingSpeed;
    [SerializeField] private float groundedDistance;
    [SerializeField] private float jumpStrength;
    [SerializeField] private float lookingSensibility;
    private float verticalRotation = 0;
    public bool characterGrounded = false;
    public Vector3 characterVelocity;
    [SerializeField] private float gravityAcc = 9.81f;

    //References and Objects
    [Multiline]
    [Header("References", order=1)]
    private InputActions inputActions;
    private CharacterController characterController;
    private Camera playerCamera;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private Transform groundCheck;
    #endregion

    private void Awake()
    {
        inputActions = new InputActions(); //Create new Instance of the InputActions
        characterController = GetComponentInChildren<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
    }

    private void Update()
    {
        //Check grounded
        characterGrounded = Physics.CheckSphere(groundCheck.position, groundedDistance, groundMask);
        if(characterGrounded && characterVelocity.y < 0f)
        {
            characterVelocity.y = 0f;
        }
        //Character Jumping
        if (inputActions.Character.Jump.WasPressedThisFrame() && characterGrounded)
        {
            characterVelocity.y += Mathf.Sqrt(jumpStrength * gravityAcc);
        }
        //Gravity
        characterVelocity.y -= gravityAcc * Time.deltaTime;
        characterController.Move(characterVelocity * Time.deltaTime);
        //Character Walking Movement
        Vector2 inputVector = inputActions.Character.Walking.ReadValue<Vector2>();
        Vector3 movementVector = transform.right * inputVector.x + transform.forward * inputVector.y;
        float usedSpeed;
        if (inputActions.Character.Aiming.IsPressed())
        {
            usedSpeed = aimingSpeed;
        }
        else if(inputActions.Character.Sprint.IsPressed())
        {
            usedSpeed = sprintingSpeed;
        }
        else
        {
            usedSpeed = movementSpeed;
        }
        characterController.Move(movementVector * usedSpeed * Time.deltaTime);
        //Character LookAround
        Vector2 lookingVector = inputActions.Character.Looking.ReadValue<Vector2>();
        //Horizontal
        transform.Rotate(Vector3.up,lookingVector.x*lookingSensibility*Time.deltaTime);
        //Vertical 
        verticalRotation -= lookingVector.y * lookingSensibility * Time.deltaTime;
        verticalRotation = Mathf.Clamp(verticalRotation, -70, 70);
        playerCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);      
   
    }

    //InputActions
    private void OnEnable()
    {
        inputActions.Enable(); // Activate Input
    }

    private void OnDisable()
    {
        inputActions.Disable(); //Deactivate Input
    }
}
