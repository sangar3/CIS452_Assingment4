using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera cam;
    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal"); //left/right movement 
       movement.y = Input.GetAxisRaw("Vertical");   //up/down movement

       mousePos =  cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); // calling both movement varaibles

        Vector3 lookDir = mousePos - rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;  //calcutes the exact angle when player presses on mouse0

        rb.rotation = angle;

    }
}
