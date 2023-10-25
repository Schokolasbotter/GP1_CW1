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
    public bool aiming = false;
    private float chargingTimer = 0f;
    [SerializeField] private float chargeTime1 = 0.5f;
    [SerializeField] private float chargeTime2 = 1f;
    [SerializeField] private int chargeLevel = 0;

    [Header("References")]
    //References
    [SerializeReference] private Camera playerCamera;
    public GameObject handWithGun;
    public GameObject regularBulletPrefab;
    public GameObject regularBulletPrefab1;
    public GameObject regularBulletPrefab2;
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
        if (weaponState == Weaponstate.Gun && inputActions.Character.Shooting.IsPressed() && aiming)
        {
            chargingTimer += Time.deltaTime;
            if (chargingTimer > chargeTime2)
            {
                chargeLevel = 2;
            }
            else if (chargingTimer > chargeTime1)
            {
                chargeLevel = 1;
            }

        }
        if (weaponState == Weaponstate.Gun && inputActions.Character.Shooting.WasReleasedThisFrame() && aiming)
        {
            shoot();
        }
    }

    private void shoot()
    {
        switch (chargeLevel)
        {
            case 0:
                Instantiate(regularBulletPrefab, gunShotPoint.transform.position, gunShotPoint.transform.rotation, bulletContainer.transform);
                break;
            case 1:
                Instantiate(regularBulletPrefab1, gunShotPoint.transform.position, gunShotPoint.transform.rotation, bulletContainer.transform);
                break;
            case 2:
                Instantiate(regularBulletPrefab2, gunShotPoint.transform.position, gunShotPoint.transform.rotation, bulletContainer.transform);
                break;

        }
        chargeLevel = 0;
        chargingTimer = 0;
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
        aiming = true;
    }

    private void regularFOV()
    {
        if (playerCamera.fieldOfView < normalFov)
        {
            playerCamera.fieldOfView += 2f;
        }
        aiming = false;
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
