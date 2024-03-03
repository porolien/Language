using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAttackState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
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
        // Lance LeftAttackState ou la projection croix si déjà fait attaque a gauche avant
        // Si joueur trop loin, lance obligatoirement la projection en croix
        // Si joueur au CAC, attaque avec l'autre arme
    }
}
