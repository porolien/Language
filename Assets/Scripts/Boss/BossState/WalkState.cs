using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
        // Si loin du joueur -> Se déplace en direction du joueur
        // Et inversement
    }

    public override void OnExit()
    {

    }

    public override void Update()
    {
        checkForTransition();
    }

    public void checkForTransition()
    {
        // Si se déplace vers le joueur, cast l'attaque standard
        // Si s'éloigne du joueur, heal / projection / tornades
        // Une fois assez proche du joueur, cast l'attaque standard (random entre les deux )
    }
}
