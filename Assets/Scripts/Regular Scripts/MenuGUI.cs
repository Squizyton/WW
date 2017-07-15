using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuGUI : MonoBehaviour {

    public bool enter_the_code = false;


    public string stringToEdit = "Enter The Code <3";

    public const int StartGUI = 1;
    public const int OPTIONS = 2;
    public const int EXTRAS = 3;

    public static int Selection = StartGUI;


	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {



    	}



    void OPTIONSMENU()
    {


        //Things Go Here. Mostly Stuff and things Carl.


    }



    void EXTRASMENU()
    {

        if (GUI.Button(new Rect(Screen.width * 0.3f, Screen.height * 0.21f, Screen.width * 0.4f, Screen.height * 0.1f), "ENTER Code"))

        {
            stringToEdit = GUI.TextField(new Rect(Screen.width * 0.3f, Screen.height * 0.30f, Screen.width * 0.4f, Screen.height * 0.1f), stringToEdit, 25);

            if (stringToEdit == "UPUPUPDOWNDOWNLEFTRIGHTLEFTRIGHTSTARTSELECT")
            {

               

            }

        }





        if (GUI.Button(new Rect(Screen.width * 0.3f, Screen.height * 0.45f, Screen.width * 0.4f, Screen.height * 0.1f), "Back"))
        {

            Selection = StartGUI;

        }

    }
    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width * 0.2f, Screen.height * 0.01f, Screen.width * 0.6f, Screen.height * 0.1f), "MAIN TITLE");
        switch (Selection)
        {
            case OPTIONS:
                OPTIONSMENU();
                break;

            case EXTRAS:
                EXTRASMENU();
                break;

            case StartGUI:
                StartMENU();
                break;
        }

    }
        void StartMENU()
        { 

      
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
		if(GUI.Button(new Rect(Screen.width*0.3f,Screen.height*0.71f, Screen.width*0.4f,Screen.height*0.1f),"EXTRAS")){




            Selection = EXTRAS;




        }
			
	}

    private void NewMethod()
    {
        OnGUI();
    }
}
