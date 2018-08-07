using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterAttack : MonoBehaviour {

    public KarakterStatusz karakter;
    public EnemyStatusz enemy;
    float karakterido;
    public Animator attackanim;
    float speed;
	
	
	void FixedUpdate ()
    {
        enemy = EnemyStatusz.FindObjectOfType<EnemyStatusz>();
        speed = attackanim.speed;
        karakter.atkspd = 1f / speed;




        if (enemy != null)
        {
            
            karakterido += Time.deltaTime;
            
            Debug.Log(karakterido);
            if (karakter.alive && karakterido >= karakter.atkspd && enemy.alive)
            {

                KarakterHit();
                karakterido = 0;
            }

            if (!karakter.alive)
            {
                if (karakterido >= 1)
                {
                    if (karakter.CurrentHP + karakter.HpReg < karakter.MaxHP)
                    {
                        karakter.CurrentHP += karakter.HpReg;
                    }
                    else
                    {
                        karakter.CurrentHP = karakter.MaxHP;
                    }

                    karakterido = 0;

                    if (karakter.CurrentHP == karakter.MaxHP)
                    {
                        karakter.alive = true;
                    }
                }

            }
        }
        else
        {
            karakterido = 0;
        
        }

    }

    void KarakterHit()
    {
        attackanim.Play("KarakterAttack");
        Debug.Log("levette a hp-bol");
        if (enemy.CurrentHP - karakter.Patk >= 0)
        {

           enemy.CurrentHP -= karakter.Patk;

        }
        else
        {
           enemy.CurrentHP = 0;
        }
    }
}
