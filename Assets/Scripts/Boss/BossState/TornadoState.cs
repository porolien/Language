using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoState : BaseBossState
{
    public override void OnEnter(BossStateMachine stateMachine)
    {
        // Se replie pendant ~1s pour cast
        
    }

    public override void OnExit()
    {

    }

    public override void Update()
    {
        // Vérifie si le cast est fini
        // Si oui, fais tourner des tornades autour de lui pendant 2s
        // Une fois le cast fini,
        // Repasse en Idle
        checkForTransition();
    }

    public void checkForTransition()
    { 
    
    }
}
