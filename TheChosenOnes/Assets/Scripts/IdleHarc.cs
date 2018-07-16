using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleHarc : MonoBehaviour {

    public KarakterStatusz karakter;
    public EnemyStatusz enemy;
    public Text Gold;
    public float gold;
    float karakterido;
    float enemyido;

	void Start () {
    }
	
	// Update is called once per frame
	void Update ()
    {

        karakterido += Time.deltaTime;
        enemyido += Time.deltaTime;
        Debug.Log(karakterido);

        if(karakter.alive&&karakterido>=karakter.atkspd&&enemy.alive)
        {
            KarakterAttack();
            karakterido = 0;
        }

        if (karakter.alive && enemyido>= enemy.atkspd && enemy.alive)
        {
            EnemyAttack();
            enemyido = 0;
        }

        if (!karakter.alive)
        {
            if(karakterido>=1)
            {
                if(karakter.CurrentHP + karakter.HpReg < karakter.MaxHP)
                {
                    karakter.CurrentHP += karakter.HpReg;
                }
                else
                {
                    karakter.CurrentHP = karakter.MaxHP;
                }
                karakterido = 0;
                if(karakter.CurrentHP==karakter.MaxHP)
                {
                    karakter.alive = true;
                }
            }
            
        }
    }

    void KarakterAttack()
    {
        if (enemy.CurrentHP - karakter.Patk >= 0)
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


    void EnemyAttack()
    {
        if (karakter.CurrentHP - enemy.Patk>=0)
        {
            karakter.CurrentHP -= enemy.Patk;
        }
        else
        {
            karakter.CurrentHP = 0;
        }
    }
}
