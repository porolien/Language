using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualWeaponsProjectionState : BaseBossState
{
    private BossStateMachine _stateMachine;
    public BaseBossState nextState;
    public override void OnEnter(BossStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
        // Lance l'animation de l'attaque o� il projette une croix
    }

    public override void OnExit()
    {

    }

    public override void Update()
    {
        // Une fois l'attaque termin�e, repasse en Idle
        checkForTransition();
    }

    public void checkForTransition()
    {
        _stateMachine.walkState.idealRange = 10f;
        _stateMachine.walkState.nextState = _stateMachine.idleState;
        _stateMachine.Transition(_stateMachine.walkState);
        // Lance RightAttackState ou la projection croix si d�j� fait attaque a droite avant
        // Si joueur trop loin, lance obligatoirement la projection en croix
        // Si joueur au CAC, attaque avec l'autre arme
    }
}
