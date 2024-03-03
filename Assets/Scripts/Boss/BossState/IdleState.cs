using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseBossState
{

    public override void OnEnter(BossStateMachine stateMachine)
    {
        // 
    }

    public override void OnExit()
    {
        // Ne fais rien
    }

    public override void Update()
    {
        checkForTransition();

    }

    public void checkForTransition()
    {
        // Verif la distance avec le joueur + ses hps ?
        // Si joueur proche, augmente les chances de faire l'attaque standard
        // Si joueur loin, + de probas de faire une projection en croix / de se heal
        // Si HP < 75% débloque le heal
        // HP < 50% débloque tornades
        // HP <25% débloque heal upgrade

        // SI joueur loin -> déplacement + attaque basique / projection (50/50 de probas) / heal (1/3 de probas pour chaque si heal pas en CD)
        // SI joueur proche -> attaque basique / recule  (50% attaque basique, 50% reculer)
    }
}
