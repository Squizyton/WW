using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(killBoom ());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator killBoom(){
		yield return new WaitForSeconds(2.0f);
		Destroy (this.gameObject);
	}
}
