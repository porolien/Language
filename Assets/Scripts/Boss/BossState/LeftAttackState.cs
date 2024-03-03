using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAttackState : BaseBossState
{
    private int randomDecision;
    private BossStateMachine _stateMachine;
    public BaseBossState nextState;
    public override void OnEnter(BossStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
        // Attaque le joueur
        // (Animation de son arme gauche)
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
        if (randomDecision < 60)
        {
            _stateMachine.Transition(_stateMachine.dualWeaponsProjectionState);
        }
        else
        {
            _stateMachine.walkState.idealRange = 10f;
            _stateMachine.walkState.nextState = _stateMachine.idleState;
            _stateMachine.Transition(_stateMachine.walkState);
        }
        // Lance RightAttackState ou la projection croix si déjà fait attaque a droite avant
        // Si joueur trop loin, lance obligatoirement la projection en croix
        // Si joueur au CAC, attaque avec l'autre arme
    }
}
