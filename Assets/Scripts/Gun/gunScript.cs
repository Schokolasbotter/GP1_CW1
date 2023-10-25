using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public Transform regularPosition;
    public Transform aimingPosition;
    public Camera playerCamera;
    public PlayerWeaponScript weaponScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool aiming = weaponScript.aiming;
        if (aiming)
        {
            transform.position = aimingPosition.position;
            transform.rotation = aimingPosition.rotation;
        }
        else
        {
            transform.position = regularPosition.position;
            transform.rotation = regularPosition.rotation;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(regularPosition.position, 0.1f);
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(aimingPosition.position, 0.1f);
    }
}
