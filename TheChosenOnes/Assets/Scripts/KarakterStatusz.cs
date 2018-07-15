using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterStatusz : MonoBehaviour {

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
	void Start () {
        CurrentHP = MaxHP;
        alive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(CurrentHP==0)
        {
            alive = false;

        }
	}
}
