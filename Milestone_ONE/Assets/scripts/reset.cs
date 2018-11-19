/*
RESET GAMEOBJECT TANK POSITION
reset.cs
JERARD CARNEY
NOVEMBER.18.2018


SUMMARY OF CODE USE:

WHEN THE PLAYER PRESSES DOWN THE SPACE KEY THE GAMEOBJECT
TANK WITH RESET TO ITS STARTING POSITION. THE IS ESTABLISHED BY
SETTING THE OBJECT LOCATION AT START AND THEN REFERRING BACK TO 
THIS POSITION WHEN SPACE IT PRESSED.
*/



// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// PULBIC CLASS... TO RESET TANK POSTION TO ORIGINAL POSITION... MONOBEHAVIOUR
public class reset : MonoBehaviour
{
    //PUBLICE VARIABLE... USING Vector3 >>> originalPos
    public Vector3 originalPos;


    // TO INITIALIZED BEFORE GAME START
    private void Awake()
    {
        // orginialPos >>> ASSIGNED POSITION OF TANK START LOCATION BEFORE GAME START
        originalPos = transform.position;
    }
    // END AWAKE


    // Use this for initialization
    void Start ()
    {
        // orginalPos >>> ASTABLISH new Vector3 AS STARTING x,y,z(z IS NOT NEEDED 2D) FOR GAME OBJECT
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
	// END START


	// Update is called once per frame
	void Update ()
    {
       // IF SPACE KEY PRESSED DOWN RESET TANK TO ORIGINAL POSITION
       if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = originalPos;
        }
    }
    // END UPDATE
}
//END CLASS
