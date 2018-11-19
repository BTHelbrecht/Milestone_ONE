/*
DEACTIVATE GAME OBJECT TANK
inactive.cs
JERARD CARNEY
NOVEMBER.18.2018


SUMMARY OF CODE USE:

WHEN THE USER PRESSES "Q" THE GAME OBJECT THAT IS THE TANK
WILL BE DEACTIVATED AND SET TO INACTIVE STATUS.
*/


// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// PUBLIC CLASS... TO SET GAMEOBJECT TO INACTIVE... MONOBEHAVIOUR
public class inactive : MonoBehaviour
{
    // PUBLIC VARIABLE >>> myLandraider >>> WILL RECIEVE GAMEOBJECT "Landraider"
    public GameObject myLandraider;
    // PUBLIC BOOLEAN disabled >>> false
    public static bool disabled = false;


	// Use this for initialization
	void Start ()
    {
        // VARIABLE myLandraider >>> FIND GAMEOBJECT "Landraider" >>> ASSIGNED
        myLandraider = GameObject.Find("Landraider");
	}
    // END START
	
	// Update is called once per frame
	void Update ()
    {
        // IF USER PRESSES "Q" SET GAMEOBJECT TO INACTIVE
        if (Input.GetKey(KeyCode.Q))
        {
            myLandraider.SetActive(false);
        }
        // IF USER PRESSES "E" SET GAMEOBJECT TO ACTIVE
        else if (Input.GetKey(KeyCode.E))
        {
            myLandraider.SetActive(true);
        }
    }
    // END UPDATE
}
//END CLASS
