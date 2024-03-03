using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
        // Si loin du joueur -> Se d�place en direction du joueur
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
        // Si se d�place vers le joueur, cast l'attaque standard
        // Si s'�loigne du joueur, heal / projection / tornades
        // Une fois assez proche du joueur, cast l'attaque standard (random entre les deux )
    }
}
