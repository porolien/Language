using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RightAttackState : BaseBossState
{
    private int randomDecision;
    private BossStateMachine _stateMachine;
    public BaseBossState nextState;
    public override void OnEnter(BossStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
        // Attaque le joueur
        // (Animation de son arme droite)
    }

    public override void OnExit()
    {

    }

    public override void Update()
    {
        // Une fois l'animation finie, 
        checkForTransition();
    }

    public void checkForTransition()
    {
        randomDecision = Random.Range(0, 100);
        if(randomDecision < 80)
        {
            _stateMachine.Transition(_stateMachine.leftAttackState);
        }
        else
        {
            _stateMachine.walkState.idealRange = 10f;
            _stateMachine.walkState.nextState = _stateMachine.idleState;
            _stateMachine.Transition(_stateMachine.walkState);
        }


        // Lance LeftAttackState ou la projection croix si d�j� fait attaque a gauche avant
        // Si joueur trop loin, lance obligatoirement la projection en croix
        // Si joueur au CAC, attaque avec l'autre arme
    }
}
