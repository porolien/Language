using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradedHealState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
        // Commence à se heal
        // Se met à tourner sur lui même en attaquant autour
        // Se heal de  ?? % de ses HP max
        // Tourne sur lui même en attaquant tout autour de lui
    }

    public override void OnExit()
    {
        // Mets l'attaque en CD pour 10s
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
