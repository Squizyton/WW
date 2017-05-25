using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {

    public float speed;
    public GameObject explosion;
    public Transform Fireball;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);


    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        Instantiate(explosion, Fireball.position, Fireball.rotation);

        



    }




}
