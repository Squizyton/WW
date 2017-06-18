using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCannon : MonoBehaviour {

    public float speed;
    public bool Fire = true;
    public GameObject FireBall;
    public Transform DebugFirePoint;
	
	// Update is called once per frame
	void Update () {

        if (Fire == true)
        {
            Instantiate(FireBall, DebugFirePoint.position, DebugFirePoint.rotation);
            Fire = false;
        }


        if (Fire == false)
        {
            StartCoroutine(AutomaticFire());
        }


	}

    IEnumerator AutomaticFire()
    {

        yield return new WaitForSeconds(6);
        Fire = true;
        

    }


}





