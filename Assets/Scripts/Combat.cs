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

	public GameObject UISys;

    public const int No_Character = 0;
    public const int CharacterPicked_Debug = 99;


    public static int WhatCharacter = No_Character;


	void Start(){
		UISys= GameObject.FindGameObjectWithTag ("UI");
	}

    void Update ()
    {
		//chooses instance of character
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
		//chaotic mana regen
		if (gameObject.tag == "Player1") {
			if (UISys.GetComponent<UI> ().FirstCurMa / UISys.GetComponent<UI> ().FirstPMa < 1) {
				UISys.GetComponent<UI> ().FirstCurMa += 0.1f;
			}
		}
		if (gameObject.tag == "Player2") {
			if (UISys.GetComponent<UI> ().SecondCurMa / UISys.GetComponent<UI> ().SecondPMa < 1) {
				UISys.GetComponent<UI> ().SecondCurMa += 0.1f;
			}
		}

        if (Input.GetKeyUp(KeyCode.Keypad5) || Input.GetButtonUp("Fire1"))
        {	

			//separates player 1 from player 2
			if (gameObject.tag == "Player1" && UISys.GetComponent<UI>().FirstCurMa >=25) {
				UISys.GetComponent<UI> ().FirstCurMa -= 25;
				Instantiate(fireball, firePoint.position, firePoint.rotation);
			}
			if (gameObject.tag == "Player2"&& UISys.GetComponent<UI>().SecondCurMa >=25) {
				UISys.GetComponent<UI> ().SecondCurMa -= 25;
				Instantiate(fireball, firePoint.position, firePoint.rotation);
			}

        }


	}
}
