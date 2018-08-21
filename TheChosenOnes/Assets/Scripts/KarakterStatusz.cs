using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KarakterStatusz : MonoBehaviour {

    public Image hpbar;
    float hpbarstatus;
    public TextMeshProUGUI DMGperS;
    public TextMeshProUGUI Attack;
    public TextMeshProUGUI AttackSpeed;
    public TextMeshProUGUI Defense;
    public TextMeshProUGUI MAXHP;
    public TextMeshProUGUI HPREG;
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
        CharacterStats();

        if (CurrentHP==0)
        {
            alive = false;
        }
	}

    public void CharacterStats()
    {
        DMGperS.text = "Dmg/s: " + (Patk * (1/atkspd));
        Attack.text = "P.atk: " + Patk;
        Defense.text = "Defense: " + Pdef;
        AttackSpeed.text = "Attackspd: " + (1/atkspd);
        MAXHP.text = "Maxhp: " + MaxHP;
        HPREG.text = "Hpreg: " + HpReg;
    }
}
