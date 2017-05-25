using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {


    public const int Canfight = 0;
    public const int BookKnockedOut = 1;
    public const int Stunned = 2;
    public const int state = Canfight;

    public const int CharacterPicked_Debug = 99;

    public const int WhatCharacter = 0;


    void Start ()
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
        Debug.Log("HEY, IM HERE! :D");


	}
}
