using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables and References
    #region
    //Variables
    [SerializeField] private float movementForce;
    [SerializeField] private float lookingSensibility;
    //References and Objects
    private InputActions inputActions;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Camera playerCamera;
    #endregion

    private void Awake()
    {
        inputActions = new InputActions(); //Create new Instance of the InputActions
        rb = GetComponent<Rigidbody>();
        playerCamera = GetComponentInChildren<Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Character Movement
        Vector2 movementVector = inputActions.Character.Walking.ReadValue<Vector2>();
        rb.AddForce(transform.forward * movementVector.y * movementForce * Time.deltaTime, ForceMode.VelocityChange); // Forward
        rb.AddForce(transform.right * movementVector.x * movementForce * Time.deltaTime, ForceMode.VelocityChange); // Sideways
    }

    private void Update()
    {
        //Character LookAround
        Vector2 lookingVector = inputActions.Character.Looking.ReadValue<Vector2>();
        Debug.Log(lookingVector.y);
        //Horizontal
        //transform.Rotate(transform.up, lookingVector.x * lookingSensibility);
        //Vertical
        float yRotation = Mathf.Clamp(playerCamera.transform.eulerAngles.y + lookingVector.y * lookingSensibility, 60f, -60f);
        transform.Rotate(0f,yRotation,0f);
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
