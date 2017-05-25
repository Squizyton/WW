using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterScript : MonoBehaviour {

    public static float Health = 100;
    public static float stamina = 100;
    public static float mana = 200;


  


    // Use this for initialization
	void Start () {

        Combat.WhatCharacter = Combat.CharacterPicked_Debug;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
