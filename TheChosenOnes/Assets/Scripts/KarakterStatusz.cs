using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarakterStatusz : MonoBehaviour {

    public Image hpbar;
    float hpbarstatus;

    public float MaxHP=100;
    public float CurrentHP;
    public float HpReg;
    public float Patk;
    public float Matk;
    public float Pdef;
    public float Mdef;
    public float atkspd;
    public float casspd;
    public float crit;
    public float magiccrit;
    public bool alive;

	// Use this for initialization
	void Start ()
    {
        CurrentHP = MaxHP;
        alive = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        hpbarstatus = CurrentHP / MaxHP;
        hpbar.rectTransform.localScale = new Vector3(hpbarstatus, 1);


        if (CurrentHP==0)
        {
            alive = false;
        }
	}
}
