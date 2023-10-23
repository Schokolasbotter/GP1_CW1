using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Unity.VisualScripting;

public class PlayerWeaponScript : MonoBehaviour
{
    private enum Weaponstate
    {
        Binoculars,
        Gun
    }

    [Header("Variables")]
    //Variables
    [SerializeField] private Weaponstate weaponState = Weaponstate.Binoculars;
    [SerializeField] private float normalFov;
    [SerializeField] private float binocularFov;
    [SerializeField] private float gunFov;

    [Header("References")]
    //References
    [SerializeReference] private Camera playerCamera;
    public GameObject handWithGun;
    public GameObject regularBulletPrefab;
    public GameObject gunShotPoint;
    public GameObject bulletContainer;
    public GameObject handWithBinoculars;
    private InputActions inputActions;

    void Update()
    {
        //Weapon Change
        if (inputActions.Character.WeaponSwap.WasPressedThisFrame() && !inputActions.Character.Aiming.IsPressed())
        {
            changeWeapon();
        }

        //Aiming
        if (inputActions.Character.Aiming.IsPressed())
        {
            aim();
        }
        else
        {
            regularFOV();
        }

        //Shooting
        if (weaponState == Weaponstate.Gun && inputActions.Character.Shooting.WasReleasedThisFrame())
        {
            regularShot();
        }
    }

    private void regularShot()
    {
        Instantiate(regularBulletPrefab, gunShotPoint.transform.position, gunShotPoint.transform.rotation, bulletContainer.transform);
    }
    void aim()
    {
        switch (weaponState)
        {
            case Weaponstate.Binoculars:
                if(playerCamera.fieldOfView > binocularFov)
                {
                    playerCamera.fieldOfView -= 2f;
                }
                break; 
            case Weaponstate.Gun:
                if (playerCamera.fieldOfView > gunFov)
                {
                    playerCamera.fieldOfView -= 2f;
                }
                break;
        }
    }

    private void regularFOV()
    {
        if (playerCamera.fieldOfView < normalFov)
        {
            playerCamera.fieldOfView += 2f;
        }
    }
    void changeWeapon()
    {
        if(weaponState == Weaponstate.Binoculars)
        {
            weaponState = Weaponstate.Gun;
            handWithBinoculars.SetActive(false);
            handWithGun.SetActive(true);
        }
        else if(weaponState == Weaponstate.Gun)
        {
            weaponState=Weaponstate.Binoculars;
            handWithGun.SetActive(false);
            handWithBinoculars.SetActive(true);
        }
    }

    void OnEnable()
    {
        inputActions = new InputActions();
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }


}
