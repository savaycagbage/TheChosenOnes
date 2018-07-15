using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarakterHPBar : MonoBehaviour {

    public Image hpbar;
    public KarakterStatusz karakter;
    float currenthp;

	
	// Update is called once per frame
	void Update () {
        currenthp = karakter.CurrentHP / karakter.MaxHP;
        Debug.Log(currenthp);
        hpbar.rectTransform.localScale = new Vector3(currenthp, 1);

    }
}
