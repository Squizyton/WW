using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

    public Transform firePoint;
    public GameObject fireball;



    public const int Canfight = 0;
    public const int BookKnockedOut = 1;
    public const int Stunned = 2;
    public const int state = Canfight;


    public const int No_Character = 0;
    public const int CharacterPicked_Debug = 99;


    public static int WhatCharacter = No_Character;


    void Update ()
    {
        switch (WhatCharacter)
        {
            case CharacterPicked_Debug:
                CharacterDebug();
                break;

        }
    }

	// Update is called once per frame
	void CharacterDebug()
    {
        Debug.Log("We made it this far");

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Debug.Log("A fireball was shot");
            Instantiate(fireball, firePoint.position, firePoint.rotation);

        }


	}
}
