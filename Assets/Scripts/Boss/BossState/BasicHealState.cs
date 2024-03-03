using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicHealState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
        // Commence à se heal
        //Se soigne de ?? % de ses HP max
        
    }

    public override void OnExit()
    {
        // Mets l'attaque en CD pour 15s
    }

    public override void Update()
    {
        // Une fois regen de ?? % de ses PV max
        // Quand le joueur lui fait ?? % de PV de dégats
        // Arrete de cast le sort
        // Repasse en Idle
        checkForTransition();
    }

    public void checkForTransition()
    {

    }
}
