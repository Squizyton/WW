﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpiral : MonoBehaviour {

    public float speed = 10, jumpVelocity = 5;
   
    public Transform Player2;

	void Start () {
		
	}

     void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }


    void  OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            Player2.GetComponent<Rigidbody2D>().velocity += jumpVelocity * Vector2.up;
        }

        
    }
}
