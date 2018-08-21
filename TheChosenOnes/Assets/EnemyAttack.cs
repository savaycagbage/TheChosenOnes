using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : StateMachineBehaviour {

    public KarakterStatusz karakter;
    public EnemyStatusz enemy;

	 
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        karakter = KarakterStatusz.FindObjectOfType<KarakterStatusz>();
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	//override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        

            if (karakter.CurrentHP - enemy.Patk >= 0)
            {
                karakter.CurrentHP -= enemy.Patk;
            }
            else
            {
                karakter.CurrentHP = 0;
            }
    }

}
