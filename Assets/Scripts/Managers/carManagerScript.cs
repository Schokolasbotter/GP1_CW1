using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraManagerScript : MonoBehaviour
{
    public PlayerMovement pm;
    public carMovement cm;
    public Camera playerCamera;
    public Camera carCamera;
    private Animator carAnimator;

    private void Start()
    {
        pm.onEnterCar.AddListener(enterCar);
        cm.onExitCar.AddListener(exitCar);
        carAnimator = cm.gameObject.GetComponentInChildren<Animator>();
    }

    private void enterCar()
    {
        //Camera Changes
        carCamera.GetComponent<Camera>().enabled = true;
        playerCamera.gameObject.SetActive(false);
        //Change COntrols
        pm.disablePlayerControls();
        cm.enableCarControls();
        //Move the player onto the car
        pm.gameObject.SetActive(false);
        pm.gameObject.transform.position = cm.characterStorage.position;
        pm.gameObject.transform.rotation = cm.characterStorage.rotation;
        pm.gameObject.transform.SetParent(cm.characterStorage.transform, false);
        //Stop animation
        carAnimator.SetBool("insideCar", true);
    }

    private void exitCar()
    {
        //Activate Player
        pm.gameObject.transform.SetParent(null,false);
        pm.gameObject.SetActive(true);
        //Camera Change
        playerCamera.gameObject.SetActive(true);
        carCamera.GetComponent<Camera>().enabled = false;
        //Change COntrols
        cm.disableCarControls();
        pm.enablePlayerControls();
        //Start Animation
        carAnimator.SetBool("insideCar", false);
    }
}
