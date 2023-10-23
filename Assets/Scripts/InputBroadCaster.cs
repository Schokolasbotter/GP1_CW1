using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Unity.VisualScripting;

public class InputBroadCaster : MonoBehaviour
{
    InputActions inputActions;

    //Events
    public VoidEventChannelSO changeWeaponEvent;

    private void Update()
    {
        if (changeWeaponEvent != null && inputActions.Character.WeaponSwap.WasPressedThisFrame()) 
        {
            changeWeaponEvent.RaiseEvent();
        }
    }

    private void OnEnable()
    {
        inputActions = new InputActions();
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
