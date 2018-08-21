using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Attack : StateMachineBehaviour {



    public TextMeshProUGUI PopUp;
    public KarakterStatusz karakter;
    float AttackRange;
    public EnemyStatusz enemy;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        karakter = KarakterStatusz.FindObjectOfType<KarakterStatusz>();
        enemy = EnemyStatusz.FindObjectOfType<EnemyStatusz>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (enemy.alive)
        {
            TextMeshProUGUI instance = Instantiate(PopUp);
            instance.transform.SetParent(GameObject.Find("Canvas").transform, false);

            AttackRange = Random.Range(Mathf.RoundToInt(karakter.Patk * 0.8f), Mathf.RoundToInt(karakter.Patk * 1.2f));
            PopUp.text = AttackRange.ToString();
            if (enemy.CurrentHP - AttackRange >= 0)
            {

                enemy.CurrentHP -= AttackRange;

            }
            else
            {
                enemy.CurrentHP = 0;
                enemy.alive = false;
            }
        }

    }

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
