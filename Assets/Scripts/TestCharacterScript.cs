using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterScript : MonoBehaviour {

	public static float P1Health = 100;
	public static float P1Stamina = 100;
	public static float P1Mana = 200;

	public static float P2Health = 100;
	public static float P2Stamina = 100;
	public static float P2Mana = 200;


  


    // Use this for initialization
	void Start () {

        Combat.WhatCharacter = Combat.CharacterPicked_Debug;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
