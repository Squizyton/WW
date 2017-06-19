using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCooldowns : MonoBehaviour
{

    public static bool CanFireBall = true;
    public static bool CanRockMine = true;
    public static bool CanGroundSpiral = true;




    // Update is called once per frame
    void Update()
    {

        if (CanFireBall == false)
        {
            StartCoroutine(FireBallCoolDown());
        }

        if (CanRockMine == false)
        {
            StartCoroutine(RockMineCoolDown());

        }
        if (CanGroundSpiral == false)
        {

            StartCoroutine(GroundSpiralCoolDown());

        }

    }


    IEnumerator FireBallCoolDown()
    {
        yield return new WaitForSeconds(.25f);
		Debug.Log ("FIRE");
        CanFireBall = true;
    }

    IEnumerator RockMineCoolDown()
    {
        yield return new WaitForSeconds(3f);
        CanRockMine = true;

    }

    IEnumerator GroundSpiralCoolDown()
    {
        yield return new WaitForSeconds(4);
        CanGroundSpiral = true;
    }


}
