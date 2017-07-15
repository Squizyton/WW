using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		GUI.Box (new Rect (Screen.width * 0.2f, Screen.height * 0.01f, Screen.width * 0.6f, Screen.height * 0.1f), "MAIN TITLE");
		if(GUI.Button(new Rect(Screen.width*0.3f,Screen.height*0.21f, Screen.width*0.4f,Screen.height*0.1f),"ARCADE MODE")){
		}
		if(GUI.Button(new Rect(Screen.width*0.3f,Screen.height*0.31f, Screen.width*0.4f,Screen.height*0.1f),"STORY MODE")){
		}
		if(GUI.Button(new Rect(Screen.width*0.3f,Screen.height*0.41f, Screen.width*0.4f,Screen.height*0.1f),"DUEL MODE")){
		}
		if(GUI.Button(new Rect(Screen.width*0.3f,Screen.height*0.51f, Screen.width*0.4f,Screen.height*0.1f),"TRAINING MODE")){
			SceneManager.LoadScene ("Character Select");
		}
		if(GUI.Button(new Rect(Screen.width*0.3f,Screen.height*0.61f, Screen.width*0.4f,Screen.height*0.1f),"OPTIONS")){
			
		}
		if(GUI.Button(new Rect(Screen.width*0.3f,Screen.height*0.71f, Screen.width*0.4f,Screen.height*0.1f),"EXTRAS")){ //If any
		}
			
	}
}
