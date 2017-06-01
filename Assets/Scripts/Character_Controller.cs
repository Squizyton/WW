using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour

{
    public float speed = 10, jumpVelocity = 10;
    public LayerMask playerMask;
    public bool canMoveInAir = true;
    Transform myTrans, tagGround;
    Rigidbody2D myBody;
    bool isGrounded = false;
    float hInput = 0;

    void Start()
    {

        myBody = this.GetComponent<Rigidbody2D>();
        myTrans = this.transform;

    }

    void FixedUpdate()
    {


        Move(Input.GetAxisRaw("Horizontal"));



        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move(float horizonalInput)
    {

        Vector2 moveVel = myBody.velocity;
        moveVel.x = horizonalInput * speed;
        myBody.velocity = moveVel;
    }

    public void Jump()
    {
        myBody.velocity += jumpVelocity * Vector2.up;
    }


}