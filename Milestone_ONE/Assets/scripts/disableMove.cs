using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableMove : MonoBehaviour
{

   public playerController move;

	// Use this for initialization
	void Start ()
    {
        move = GetComponent<playerController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyUp(KeyCode.P))
        {
            move.enabled = !move.enabled;
        }
    }
}
