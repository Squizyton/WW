using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterChooser : MonoBehaviour {

    public bool HasPicked = false;



    public const int Bob = 2;
    public const int Larry = 3;
    public const int Harold = 4;
    public const int Jim  = 5;

    public static int CharacterSelected = 0;



    // Use this for initialization
    void OnGUI() {



        if (GUI.Button(new Rect(Screen.width * .30f, Screen.height * .35f, 100, 100), "Larry"))
        {

            CharacterSelected = 3;
            HasPicked = true;

        }
        if (GUI.Button(new Rect(Screen.width * .40f, Screen.height * .35f, 100, 100), "Harold"))
        {
            CharacterSelected = 4;
            HasPicked = true;

        }

        if (GUI.Button(new Rect(Screen.width * .50f, Screen.height * .35f, 100, 100), "Jim"))

        {
            CharacterSelected = 5;
            HasPicked = true;

        }

        if (GUI.Button(new Rect(Screen.width * .60f, Screen.height * .35f, 100, 100), "Bob"))

        {

            CharacterSelected = 2;
            HasPicked = true;
        }


    }

    // Update is called once per frame
    void Update () {

        if (HasPicked == true)
        {

            SceneManager.LoadScene("Combat Testing");
        


        }



	}

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

}
