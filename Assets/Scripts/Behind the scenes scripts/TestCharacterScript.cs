using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterScript : MonoBehaviour {

	public float Health = 100;
	public float Stamina = 100;
	public float Mana = 200;


  


    // Use this for initialization
	void Start () {

        Combat.WhatCharacter = Combat.CharacterPicked_Debug;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
