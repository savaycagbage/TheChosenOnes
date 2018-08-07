using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStatusz : MonoBehaviour
{


    public Pénzeszközök pénz;
    public KarakterStatusz karakter;
    public Image hpbar;
    public Animator attackanim;
    float hpbarstatus;

    public float MaxHP = 100;
    public float CurrentHP;
    public float Patk;
    public float Matk;
    public float Pdef;
    public float Mdef;
    public float casspd;
    public float crit;
    public float magiccrit;
    public bool alive;
    public float GoldDrop;
    float ido;


    void Start ()
    {
        pénz = Currencies.FindObjectOfType<Currencies>();
        karakter = KarakterStatusz.FindObjectOfType<KarakterStatusz>();
        CurrentHP = MaxHP;
        alive = true;
        ido = 0;

	}


	
	void Update ()
    {
        
        hpbarstatus = CurrentHP / MaxHP;
        hpbar.rectTransform.localScale = new Vector3(hpbarstatus, 1);
        if (karakter.alive)
        {
            ido += Time.deltaTime;
            attackanim.Play("EnemyAttack");
            if (ido>=1.5)
            {
                EnemyAttack();
                ido = 0;
            }
        }

        if (CurrentHP<=0)
        {
            alive = false;
            pénz.gold += GoldDrop;
            
            Destroy(this.gameObject);
        }
		
	}







    void EnemyAttack()
    {
        

        if (karakter.CurrentHP - Patk >= 0)
        {
            karakter.CurrentHP -= Patk;
        }
        else
        {
            karakter.CurrentHP = 0;
        }
    }
}
