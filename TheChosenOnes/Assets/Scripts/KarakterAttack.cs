using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KarakterAttack : MonoBehaviour
{

    public KarakterStatusz karakter;
    public EnemyStatusz enemy;
    float karakterido;
    public Animator attackanim;
    public TextMeshProUGUI PopUp;
    float speed;
    float AttackRange;
    float ido2;

    void FixedUpdate()
    {
        enemy = EnemyStatusz.FindObjectOfType<EnemyStatusz>();
        speed = attackanim.speed;
        karakter.atkspd = 1f / speed;




        if (enemy != null)
        {


            karakterido += Time.deltaTime;

            if (karakter.alive && enemy.alive)
            {


                if (karakterido >= karakter.atkspd)
                {
                    attackanim.Play("Karakter_Attack_anim");
                    karakterido = 0;
                }

            }
            else
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
            attackanim.Play("Idle_animation");
            karakterido = 0;

        }

    }
}
