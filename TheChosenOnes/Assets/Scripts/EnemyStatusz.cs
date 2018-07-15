using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusz : MonoBehaviour {

    public float MaxHP = 100;
    public float CurrentHP;
    public float Patk;
    public float Matk;
    public float Pdef;
    public float Mdef;
    public float atkspd;
    public float casspd;
    public float crit;
    public float magiccrit;
    public bool alive;
    public float GoldDrop;
    void Start () {

        CurrentHP = MaxHP;
        alive = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
