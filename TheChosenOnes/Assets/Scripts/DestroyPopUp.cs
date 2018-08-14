using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPopUp : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start ()
    {

        yield return StartCoroutine("Torles");

        Destroy(this.gameObject);
	}

    IEnumerator Torles()
    {
        yield return new WaitForSeconds(2);
    }


}
