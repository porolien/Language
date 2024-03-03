using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftAttackState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
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
        // Lance RightAttackState ou la projection croix si déjà fait attaque a droite avant
        // Si joueur trop loin, lance obligatoirement la projection en croix
        // Si joueur au CAC, attaque avec l'autre arme
    }
}
