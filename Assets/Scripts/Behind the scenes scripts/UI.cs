using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {


	public float FirstPHp;
	public float FirstCurHp;
	public float FirstPSt;
	public float FirstCurSt;
	public float FirstPMa;
	public float FirstCurMa;

	public float SecondPHp;
	public float SecondPSt;
	public float SecondPMa;
	public float SecondCurSt;
	public float SecondCurMa;
	public float SecondCurHp;

	public GameObject PlayerOne;
	public GameObject PlayerTwo;

	public GUIStyle HeBarP1;
	public GUIStyle MaBarP1;
	public GUIStyle StBar;
	public GUIStyle HeBarP2;
	public GUIStyle MaBarP2;




	// Use this for initialization
	void Start () {
		PlayerOne = GameObject.FindGameObjectWithTag ("Player1");
		PlayerTwo = GameObject.FindGameObjectWithTag ("Player2");


		FirstPHp = PlayerOne.GetComponent<TestCharacterScript> ().Health;
		FirstCurHp = PlayerOne.GetComponent<TestCharacterScript> ().Health;
		FirstPSt = PlayerOne.GetComponent<TestCharacterScript> ().Stamina;
		FirstCurSt = PlayerOne.GetComponent<TestCharacterScript> ().Stamina;
		FirstPMa = PlayerOne.GetComponent<TestCharacterScript> ().Mana;
		FirstCurMa = PlayerOne.GetComponent<TestCharacterScript> ().Mana;

		SecondPHp = PlayerTwo.GetComponent<TestCharacterScript> ().Health;
		SecondCurHp = PlayerTwo.GetComponent<TestCharacterScript> ().Health;
		SecondPSt = PlayerTwo.GetComponent<TestCharacterScript> ().Stamina;
		SecondCurSt = PlayerTwo.GetComponent<TestCharacterScript> ().Stamina;
		SecondPMa = PlayerTwo.GetComponent<TestCharacterScript> ().Mana;
		SecondCurMa = PlayerTwo.GetComponent<TestCharacterScript> ().Mana;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Keypad0)) {
			FirstCurSt--;
			SecondCurSt--;
		}
		//makes sure health doesn't over heal
		if (FirstCurHp / FirstPHp > 1) {
			SecondCurHp = FirstPHp;
		}
		if (FirstCurHp / SecondPHp > 1) {
			SecondCurHp = SecondPHp;
		}
		//makes sure hp doesn't go under 0
		if (FirstCurHp / FirstPHp <= 0) {
			FirstCurHp = 0;
		}
		if (SecondCurHp / SecondPHp <= 0) {
			SecondCurHp = 0;
		}

		if (FirstCurSt / FirstPSt <= 0) {
			FirstCurSt = FirstPSt;
			SecondCurSt = SecondPSt;
		}
			

		
	}

	void OnGUI(){
		//P1 UI
		GUI.Box(new Rect(0,0,Screen.width*0.1f,Screen.height*0.1f), "P1 ICON");
		GUI.Box(new Rect(Screen.width*0.1f,0,Screen.width*0.35f,Screen.height*0.06f), "HP: "+Mathf.RoundToInt(FirstCurHp)+"/"+FirstPHp);
		GUI.Box(new Rect(Screen.width * 0.1f, 0, Screen.width*(0.35f*(FirstCurHp/FirstPHp)), Screen.height * 0.06f),"  ",HeBarP1);
		GUI.Box(new Rect(Screen.width*0.1f,Screen.height*0.06f,Screen.width*0.35f,Screen.height*0.04f), "MP: "+Mathf.RoundToInt(FirstCurMa)+"/"+FirstPMa);
		GUI.Box(new Rect(Screen.width * 0.1f, Screen.height*0.06f, Screen.width*(0.35f*(FirstCurMa/FirstPMa)), Screen.height * 0.04f),"  ",MaBarP1);
		GUI.Box(new Rect(0,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.35f), "SP: "+Mathf.RoundToInt(FirstCurSt)+"/"+FirstPSt);
		GUI.Box(new Rect(0,Screen.height*0.1f,Screen.width*0.05f,Screen.height*(0.35f*(FirstCurSt/FirstPSt))), "  ", StBar);
		GUI.Box(new Rect(Screen.width*0.05f ,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P1 OPEN");
		GUI.Box(new Rect(Screen.width*0.1f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P1 DODGE");
		GUI.Box(new Rect(Screen.width*0.15f ,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P1 COUNTER");
		GUI.Box(new Rect(Screen.width*0.35f,Screen.height*0.1f,Screen.width*0.1f,Screen.height*0.05f), "P1 WINS");
		//TIME
		GUI.Box(new Rect(Screen.width*0.45f,0,Screen.width*0.1f,Screen.height*0.1f), "TIME");
		//P2 UI
		GUI.Box(new Rect(Screen.width*0.9f ,0,Screen.width*0.1f,Screen.height*0.1f), "P2 ICON");
		GUI.Box(new Rect(Screen.width*0.55f,0,Screen.width*0.35f,Screen.height*0.06f), "HP: "+SecondCurHp+"/"+SecondPHp);
		GUI.Box(new Rect(Screen.width*0.55f+(Screen.width*(0.35f*(1-(SecondCurHp/SecondPHp)))),0,Screen.width*(0.35f*(SecondCurHp/SecondPHp)),Screen.height*0.06f), "  ",HeBarP2);
		GUI.Box(new Rect(Screen.width*0.55f ,Screen.height*0.06f,Screen.width*0.35f,Screen.height*0.04f), "MP: "+ SecondCurMa+"/"+SecondPMa);
		GUI.Box(new Rect(Screen.width*0.55f+(Screen.width*(0.35f*(1-(SecondCurMa/SecondPMa)))),Screen.height*0.06f,Screen.width*(0.35f*(SecondCurMa/SecondPMa)),Screen.height*0.04f), "  ",MaBarP2);
		GUI.Box(new Rect(Screen.width*0.95f ,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.35f), "SP: "+SecondCurSt+"/"+SecondPSt);
		GUI.Box(new Rect(Screen.width*0.95f ,Screen.height*0.1f,Screen.width*0.05f,Screen.height*(0.35f*(SecondCurSt/SecondPSt))), "  ",StBar);
		GUI.Box(new Rect(Screen.width*0.9f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P2 OPEN");
		GUI.Box(new Rect(Screen.width*0.85f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P2 DODGE");
		GUI.Box(new Rect(Screen.width*0.8f,Screen.height*0.1f,Screen.width*0.05f,Screen.height*0.05f), "P2 COUNTER");
		GUI.Box(new Rect(Screen.width*0.55f,Screen.height*0.1f,Screen.width*0.1f,Screen.height*0.05f), "P2 WINS");

	}
}
