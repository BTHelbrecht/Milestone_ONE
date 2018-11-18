using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
   
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public bool canMove = true;

    void Start()
    {

    }

    void Update()
    {
       

        if (canMove == true)
        {

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

            ///////////////////////////////////////////////////////////////////////////////////////

            if (Input.GetMouseButton(1) || (Input.GetKey(KeyCode.UpArrow)))
            {
                mousePosition = Input.mousePosition;
                mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
            }

            ///////////////////////////////////////////////////////////////////////////////////////

            if (Input.GetKeyDown(KeyCode.LeftArrow) && (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)))
            {
                Vector3 position = this.transform.position;
                position.x--;
                this.transform.position = position;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow) && (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)))
            {
                Vector3 position = this.transform.position;
                position.x++;
                this.transform.position = position;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) && (Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift)))
            {
                Vector3 position = this.transform.position;
                position.y--;
                this.transform.position = position;
            }
        }
    }
}
