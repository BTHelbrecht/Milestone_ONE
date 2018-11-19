/*
DISABLE MOVEMENT
disableMove.cs
JERARD CARNEY
NOVEMBER.18.2018


SUMMARY OF CODE USE:

THIS IS TO DISABLE THE PLAYER FROM MOVING WHEN PRESSING THE KEY
"P" AND THEN ALLOWING THEM TO MOVE AGAIN WHEN RE-PRESSING THE 
KEY "P". 
*/


// LIBRARIES 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// PUBLIC CLASS... FOR DISABLEING PLAYER MOVEMENT... MONOBEHAVIOUR
public class disableMove : MonoBehaviour
{

    //PUBLICE VARIABLE... USING playerController.cs >>> move
    public playerController move;


	// Use this for initialization
	void Start ()
    {
        // ASTABLISH AT START move >>> GET >>> playerControl.cs COMPONENT
        move = GetComponent<playerController>();
	}
    // END START
	

	// Update is called once per frame
	void Update ()
    {
        // IF USER PRESSES "P" >>> move BECOMES WHAT move IS CURRENTLY NOT
        if(Input.GetKeyUp(KeyCode.P))
        {
            move.enabled = !move.enabled;
        }
    }
    // END UPDATE
}
// END CLASS
