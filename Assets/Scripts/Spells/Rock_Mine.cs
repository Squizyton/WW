using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Mine : MonoBehaviour {
    public Transform Rocks; 
    public GameObject UISys;
    public float speed;
    public GameObject MiniRocks;


	void Start () {

        UISys = GameObject.FindGameObjectWithTag("UI");

	}

	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(speed,0, GetComponent<Rigidbody2D>().velocity.y); 
	}


    void OnTriggerEnter2D (Collider2D collision)
    {

        if (collision.gameObject.tag == "Player2")
        {
            
            UISys.GetComponent<UI>().SecondCurHp -=15;
            Destroy(gameObject);
            Instantiate(MiniRocks, Rocks.position, Rocks.rotation);
            Instantiate(MiniRocks, Rocks.position, Rocks.rotation);




        }


    }





}
