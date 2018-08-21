using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CombatUpgrade : MonoBehaviour {

    public GameObject panel;
    public KarakterStatusz karakter;
    public Currencies currencies;
    public float AttackCost=10;
    public float AttackLevel = 0;
    public float DefenseCost = 10;
    public float DefenseLevel = 0;
    public float HealthCost = 10;
    public float HealthLevel=0;
    public float HpRegCost = 10;
    public float HpRegLevel = 0;

    public void PanelOnOff()
    {
        
       if(panel.activeSelf==true)
        {
            panel.SetActive(false);
        }
       else
        {
            panel.SetActive(true);
        }

       
    }

    public void DefenseUpgrade()
    {
        if (currencies.gold >= DefenseCost)
        {
            karakter.Pdef = karakter.Pdef + Mathf.RoundToInt((karakter.Pdef * 0.1f));
            currencies.gold -= DefenseCost;
            DefenseCost = Mathf.RoundToInt(DefenseCost * 1.1f);

            DefenseLevel++;
        }
    }

    public void AttackUpgrade()
    {
        if (currencies.gold >= AttackCost)
        {
            karakter.Patk = karakter.Patk + Mathf.RoundToInt((karakter.Patk * 0.1f));
            currencies.gold -= AttackCost;
            AttackCost = Mathf.RoundToInt(AttackCost * 1.1f);

            AttackLevel++;
        }
    }
    public void HealthUpgrade()
    {
        if (currencies.gold >= HealthCost)
        {
            karakter.MaxHP = karakter.MaxHP + Mathf.RoundToInt((karakter.MaxHP * 0.1f));
            currencies.gold -= HealthCost;
            HealthCost = Mathf.RoundToInt(HealthCost * 1.1f);

            HealthLevel++;
        }
    }

    public void HpRegUpgrade()
    {
        if (currencies.gold >= HpRegCost)
        {
            karakter.HpReg = karakter.HpReg + Mathf.RoundToInt((karakter.HpReg * 0.1f));
            currencies.gold -= HpRegCost;
            HpRegCost = Mathf.RoundToInt(HpRegCost * 1.1f);

            HpRegLevel++;
        }
    }


}
