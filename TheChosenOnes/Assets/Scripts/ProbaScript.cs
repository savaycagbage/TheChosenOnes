using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbaScript : MonoBehaviour {

    public Animator animspeed;

	public void ProbaClick()
    {
        animspeed.speed = animspeed.speed * 1.5f;
    }
}
