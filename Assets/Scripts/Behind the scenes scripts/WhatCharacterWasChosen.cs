using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCharacterWasChosen : MonoBehaviour {

    public Transform Bobby,Harold2,Jim2,Larry2, SpawnPoint;

    public bool Spawned = false;

	void Update () {


        switch (CharacterChooser.CharacterSelected)
        {
            case 2:
                Bob();
                break;
            case 3:
                Larry();
                break;
            case 4:
               Harold();
                break;
            case 5:
               Jim();
                break;
        }



	}

    void Bob()
    {
        if (Spawned == false)
        { 
        Instantiate(Bobby, SpawnPoint.position, SpawnPoint.rotation);
        Destroy(GameObject.Find("Character Chooser"));
        Spawned = true;
    }

    }

    void Larry()

    {
        {
            if (Spawned == false)
                Instantiate(Larry2, SpawnPoint.position, SpawnPoint.rotation);
            Destroy(GameObject.Find("Character Chooser"));
            Spawned = true;
        }

        }
    void Jim()

    {
        if (Spawned == false)
        { 
            Instantiate(Jim2, SpawnPoint.position, SpawnPoint.rotation);
        Destroy(GameObject.Find("Character Chooser"));
        Spawned = true;
    }
    }
    void Harold()

    {
        if (Spawned == false)
        {
            Instantiate(Harold2, SpawnPoint.position, SpawnPoint.rotation);
            Destroy(GameObject.Find("Character Chooser"));
            Spawned = true;
        }
        }
}
