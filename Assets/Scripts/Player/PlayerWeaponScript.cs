using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Unity.VisualScripting;
using UnityEditor.Rendering;

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
    [SerializeField][Range(1f,100f)] private float fovSpeed;
    public AnimationCurve binoculareCurve = new AnimationCurve();
    private float t = 0;
    public bool aiming = false;
    public bool charging = false;
    private float chargingTimer = 0f;
    [SerializeField] private float chargeTime1 = 0.5f;
    [SerializeField] private float chargeTime2 = 1f;
    public int chargeLevel = 0;

    [Header("References")]
    //References
    [SerializeReference] private Camera playerCamera;
    public GameObject handWithGun;
    public GameObject regularBulletPrefabS;
    public GameObject regularBulletPrefabM;
    public GameObject regularBulletPrefabL;
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
            aiming = true;
            t = Mathf.Clamp01(t + (fovSpeed * Time.deltaTime));
        }
        else
        {
            aiming = false;
            t = Mathf.Clamp01(t - (fovSpeed * Time.deltaTime));
        }
        aim();

        //Shooting
        if (weaponState == Weaponstate.Gun && inputActions.Character.Shooting.IsPressed() && aiming)
        {
            charging = true;
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
        else { charging = false;}

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
                Instantiate(regularBulletPrefabS, gunShotPoint.transform.position, gunShotPoint.transform.rotation, bulletContainer.transform);
                break;
            case 1:
                Instantiate(regularBulletPrefabM, gunShotPoint.transform.position, gunShotPoint.transform.rotation, bulletContainer.transform);
                break;
            case 2:
                Instantiate(regularBulletPrefabL, gunShotPoint.transform.position, gunShotPoint.transform.rotation, bulletContainer.transform);
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
                playerCamera.fieldOfView = Mathf.Lerp(normalFov, binocularFov, binoculareCurve.Evaluate(t));

                break; 
            case Weaponstate.Gun:
                playerCamera.fieldOfView = Mathf.Lerp(normalFov, gunFov, t);
                break;
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
