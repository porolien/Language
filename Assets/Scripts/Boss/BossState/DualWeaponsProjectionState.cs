using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualWeaponsProjectionState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
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

    }
}
