/*
QUIT BY ESCAPE
quit.cs
JERARD CARNEY
NOVEMBER.18.2018


SUMMARY OF CODE USE:

WHEN USER PRESSES THE ESCAPE BUTTON THE APPLICATION WILL QUIT.
*/


// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// PUBLIC CLASS... TO QUIT APPLICATION... MONOBEHAVIOUR
public class quit : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		// EMPTY
	}
    // END START
	
	// Update is called once per frame
	void Update ()
    {
        // IF ESCAPE KEY PRESSED >>> PREFORM APPLICATION >>> QUIT
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    // END UPDATE
}
//END CLASS
