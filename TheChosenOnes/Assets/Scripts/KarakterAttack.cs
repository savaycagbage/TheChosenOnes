using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KarakterAttack : MonoBehaviour {

    public KarakterStatusz karakter;
    public EnemyStatusz enemy;
    float karakterido;
    public Animator attackanim;
    public TextMeshProUGUI PopUp;
    float speed;
    float AttackRange;
	
	void FixedUpdate ()
    {
        enemy = EnemyStatusz.FindObjectOfType<EnemyStatusz>();
        speed = attackanim.speed;
        karakter.atkspd = 1f / speed;
        



        if (enemy != null)
        {
            
            karakterido += Time.deltaTime;
            
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
        TextMeshProUGUI instance=Instantiate(PopUp);
        instance.transform.SetParent(GameObject.Find("Canvas").transform, false);
        
        
        attackanim.Play("KarakterAttack");
        AttackRange = Random.Range(Mathf.RoundToInt(karakter.Patk*0.8f),Mathf.RoundToInt(karakter.Patk * 1.2f));
        PopUp.text = AttackRange.ToString();
        if (enemy.CurrentHP - AttackRange >= 0)
        {

           enemy.CurrentHP -= AttackRange;

        }
        else
        {
           enemy.CurrentHP = 0;
        }
    }
}
