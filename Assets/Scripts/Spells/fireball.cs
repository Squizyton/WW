using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {

    public float speed;
    public GameObject explosion;
	public GameObject UISys;
    public Transform Fireball;
    

	// Use this for initialization
	void Start () {
		UISys = GameObject.FindGameObjectWithTag ("UI");
        StartCoroutine(DeathTimer());

    }
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);


    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        
		if (collision.gameObject.tag == "Player2") {
			UISys.GetComponent<UI> ().SecondCurHp-=5;
			Destroy (gameObject);
			Instantiate (explosion, Fireball.position, Fireball.rotation);
		}
        



    }

    IEnumerator DeathTimer()
    {

        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);

    }

}
