using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleHarc : MonoBehaviour {

    public KarakterStatusz karakter;
    public EnemyStatusz enemy;
    public Text Gold;
    public float gold;
	void Start () {
        InvokeRepeating("Harc", 1f, 1f);
        Gold.text = gold.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Harc()
    {
        if (karakter.CurrentHP - enemy.Patk>=0)
        {
            karakter.CurrentHP -= enemy.Patk;
        }
        else
        {
            karakter.CurrentHP = 0;
        }

        if(enemy.CurrentHP - karakter.Patk>=0)
        {
            enemy.CurrentHP -= karakter.Patk;
        }
        else
        {
            enemy.CurrentHP = 0;
            gold += enemy.GoldDrop;
            Gold.text = gold.ToString();
            enemy.CurrentHP = enemy.MaxHP;
        }
    }
}
