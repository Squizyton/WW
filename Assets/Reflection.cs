using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{

    public float speed = 10;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
        StartCoroutine(DeathTimer());

    }

    IEnumerator DeathTimer()
    {
        yield return new WaitForSeconds(.3f);
        Destroy(gameObject);

    }

    public void OnTriggerEnter(Collider other)
    {
        


    }




}
