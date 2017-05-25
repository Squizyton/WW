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

	void OnGUI(){
		//P1 UI
		GUI.Box(new Rect(0,0,Screen.width*0.1f,Screen.height*0.1f), "P1 ICON");
		GUI.Box(new Rect(Screen.width*0.1f,0,Screen.width*0.35f,Screen.height*0.06f), "P1 HEALTH");
		GUI.Box(new Rect(Screen.width*0.1f,Screen.height*0.06f,Screen.width*0.35f,Screen.height*0.04f), "P1 MANA");
		GUI.Box(new Rect(0,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.35f), "P1 STAMINA");
		GUI.Box(new Rect(Screen.width*0.05f ,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P1 OPEN");
		GUI.Box(new Rect(Screen.width*0.1f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P1 DODGE");
		GUI.Box(new Rect(Screen.width*0.15f ,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P1 COUNTER");
		GUI.Box(new Rect(Screen.width*0.35f,Screen.height*0.1f,Screen.width*0.1f,Screen.height*0.05f), "P1 WINS");
		//TIME
		GUI.Box(new Rect(Screen.width*0.45f,0,Screen.width*0.1f,Screen.height*0.1f), "TIME");
		//P2 UI
		GUI.Box(new Rect(Screen.width*0.9f ,0,Screen.width*0.1f,Screen.height*0.1f), "P2 ICON");
		GUI.Box(new Rect(Screen.width*0.55f,0,Screen.width*0.35f,Screen.height*0.06f), "P2 HEALTH");
		GUI.Box(new Rect(Screen.width*0.55f ,Screen.height*0.06f,Screen.width*0.35f,Screen.height*0.04f), "P2 MANA");
		GUI.Box(new Rect(Screen.width*0.95f ,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.35f), "P2 STAMINA");
		GUI.Box(new Rect(Screen.width*0.9f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P2 OPEN");
		GUI.Box(new Rect(Screen.width*0.85f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P2 DODGE");
		GUI.Box(new Rect(Screen.width*0.8f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P2 COUNTER");
		GUI.Box(new Rect(Screen.width*0.55f,Screen.height*0.1f,Screen.width*0.1f,Screen.height*0.05f), "P2 WINS");

	}
}
