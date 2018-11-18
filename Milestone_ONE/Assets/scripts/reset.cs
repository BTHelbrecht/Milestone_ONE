using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

   public Vector3 originalPos;

    private void Awake()
    {
        originalPos = transform.position;
        print(originalPos);
    }

    // Use this for initialization
    void Start ()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
	
	// Update is called once per frame
	void Update ()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = originalPos;
            print("Reset");
        }
    }
}
