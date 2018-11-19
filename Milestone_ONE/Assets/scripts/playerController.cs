/*
PLAYER CONTROLS FOR TANK
playerControllers.cs
JERARD CARNEY
NOVEMBER.18.2018


SUMMARY OF CODE USE:

CONTROLS FOR THE PLAYER TO USE THE TANK. THE TANK WILL FOLLOW THE
POINTER AND MOVE FORWARD IF THE RIGHT MOUSE BUTTON IS CLICKED/ IF
THE UP ARROW IS PRESSED. TANK WILL JUMP ONE METER/UNIT IF THE DIRECTIONS
OF RIGHT/LEFT/DOWN ARROW UPON PRESS DOWN ONLY. WHILE MOVING ONE UNIT THE 
TANK STILL FACES THE POINT LOCATION. THE TANK SPEED FOR MOVING IS RELITIVELY
FAST AND SET AT .1f.
*/


// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// PUBLIC CLASS... FOR PLAYER TO MOVE TANK AROUND SCREEN... MONOBEHAVIOUR
public class playerController : MonoBehaviour
{
    // PRIVATE VARIABLE Vector3 >>> FOR mousePosition
    private Vector3 mousePosition;
    // PUBLIC VARIABLE... FLOAT FOR DEC. >>> moveSpeed >>> ASSIGNED 0.1f FOR TANK SPEED
    public float moveSpeed = 0.1f;


    // Use this for initialization
    void Start()
    {
        // EMPTY
    }
    //END START


    // Update is called once per frame
    void Update()
    {
        // ASSIGNS Vector3 TO MOUSE CURRENT POSTION
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // ROTATES TANK TO FACE THE MOUSE POSITION/Vector3 CURRENT POSITION
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);


        // IF THE UP ARROW OR RIGHT MOUSE BUTTON IS PRESSED >>> MOVE TANK TO CURRENT POINTER POSITION 
        if (Input.GetMouseButton(1) || (Input.GetKey(KeyCode.UpArrow)))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }

        // IF LEFT ARROW PRESSED DOWN AND EITHER SHIFT ARE PRESSED >>> MOVE TANK LEFT ONE UNIT ON x AXIS
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        // IF RIGHT ARROW PRESSED DOWN AND EITHER SHIFT ARE PRESSED >>> MOVE TANK LEFT ONE UNIT ON x AXIS
        if (Input.GetKeyDown(KeyCode.RightArrow) && (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }

        // IF DOWN ARROW PRESSED DOWN AND EITHER SHIFT ARE PRESSED >>> MOVE TANK LEFT ONE UNIT ON y AXIS
        if (Input.GetKeyDown(KeyCode.DownArrow) && (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        } 
    }
    // END UPDATE
}
// END CLASS
