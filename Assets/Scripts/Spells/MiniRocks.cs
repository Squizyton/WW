using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniRocks : MonoBehaviour {
   
    public Transform[] PlacesItCanGo;
    public float speed;
    public Transform PlaceItIsGoing;
    public GameObject UISys;

    void Start()
    {
        PlaceItIsGoing = PlacesItCanGo[Random.Range(1, 5)];
        Debug.Log("The Rock is going to" + PlaceItIsGoing);
    }




    // Update is called once per frame
    void Update () {
        transform.position = Vector2.MoveTowards(transform.position, PlaceItIsGoing.position, speed * Time.deltaTime);
        transform.DetachChildren();
    }
         void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player2")
        {
            UISys.GetComponent<UI>().SecondCurHp -= 2;
            Debug.Log("YO GET DESTROYED");
            Destroy(gameObject);

        }

    }

}



