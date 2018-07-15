using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPBar : MonoBehaviour {

    public Image hpbar;
    public EnemyStatusz enemy;
    float currenthp;

    
	void Update () {

        currenthp = enemy.CurrentHP / enemy.MaxHP;
        hpbar.rectTransform.localScale = new Vector3(currenthp, 1);
	}
}
