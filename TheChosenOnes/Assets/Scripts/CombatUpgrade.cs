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
}
