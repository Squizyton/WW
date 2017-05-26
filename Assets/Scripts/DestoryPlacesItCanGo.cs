using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPlacesItCanGo : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(DestroyPlacesItCanGo());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator DestroyPlacesItCanGo()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(this.gameObject);
    }
}
