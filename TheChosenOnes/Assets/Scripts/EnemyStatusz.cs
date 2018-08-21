using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyStatusz : MonoBehaviour
{


    public Currencies pénz;
    public KarakterStatusz karakter;
    public Image hpbar;
    public Animator attackanim;
    public Level_Stage szint;
    public TextMeshProUGUI BOSS;
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
        szint = Level_Stage.FindObjectOfType<Level_Stage>();



        Patk = Patk * Mathf.Pow(1.3f, szint.level-1);
        Patk=Mathf.RoundToInt(Patk);
        MaxHP = MaxHP * Mathf.Pow(1.3f, szint.level-1);
        MaxHP=Mathf.RoundToInt(MaxHP);
        GoldDrop = GoldDrop * Mathf.Pow(1.3f, szint.level-1);
        GoldDrop=Mathf.RoundToInt(GoldDrop);
        
        if(szint.stage==10)
        {
            BOSS.enabled = true;
            Patk = Patk * 2;
            MaxHP = MaxHP * 2;
            GoldDrop = GoldDrop * 2;
        }
        else
        {
            BOSS.enabled = false;
        }


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
            
            if (ido>=1f)
            {
                EnemyAttack();
                ido = 0;
            }
        }

        if (CurrentHP<=0)
        {
            alive = false;
            pénz.gold += GoldDrop;
            if(szint.stage==10)
            {
                szint.level +=1;
                szint.stage = 1;
            }
            else
            {
                szint.stage += 1;
            }
            
            Destroy(this.gameObject);
        }
		
	}


    void EnemyAttack()
    {
        attackanim.Play("Enemy_Attack_anim");
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
