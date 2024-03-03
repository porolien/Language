using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IdleState : BaseBossState
{
    private BossStateMachine _stateMachine;
    public float distance;

    private int randomDecision;

    public override void OnEnter(BossStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
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
        distance = Vector3.Distance(_stateMachine.playerMain.transform.position, _stateMachine.bossMain.transform.position);
        randomDecision = Random.Range(0, 100);
        Debug.Log(distance);
        randomDecision = 20;
        if (distance >= _stateMachine.distanceMax)
        {
            if (_stateMachine.bossMain.bossStats.percentHP < 25)
            {
                if ( randomDecision < 40)
                {
                    // Attaque basique
                    _stateMachine.walkState.nextState = _stateMachine.rightAttackState;
                    _stateMachine.Transition(_stateMachine.walkState);
                }
                else if (randomDecision < 60)
                {
                    // Heal Upgraded
                    _stateMachine.Transition(_stateMachine.upgradedHealState);
                }
                else if (randomDecision < 85)
                {
                    // Tornade
                    _stateMachine.Transition(_stateMachine.tornadoState);
                }
                else
                {
                    // Projection
                    _stateMachine.Transition(_stateMachine.dualWeaponsProjectionState);
                }
            }
            else if (_stateMachine.bossMain.bossStats.percentHP < 50)
            {
                if (randomDecision < 50)
                {
                    // Déplacement
                    _stateMachine.walkState.nextState = _stateMachine.rightAttackState;
                    _stateMachine.Transition(_stateMachine.walkState);
                }
                else if (randomDecision < 60)
                {
                    // Heal
                    _stateMachine.Transition(_stateMachine.basicHealState);

                }
                else if (randomDecision < 75)
                {
                    // Tornade
                    _stateMachine.Transition(_stateMachine.tornadoState);
                }
                else
                {
                    // Projection
                    _stateMachine.Transition(_stateMachine.dualWeaponsProjectionState);
                }
            }
            else if (_stateMachine.bossMain.bossStats.percentHP < 75)
            {
                if (randomDecision < 50)
                {
                    // Déplacement
                    _stateMachine.walkState.nextState = _stateMachine.rightAttackState;
                    _stateMachine.Transition(_stateMachine.walkState);

                }
                else if (randomDecision < 65)
                {
                    // Heal 
                    _stateMachine.Transition(_stateMachine.basicHealState);
                }
                else
                {
                    // Projection
                    _stateMachine.Transition(_stateMachine.dualWeaponsProjectionState);
                }
            }
            else
            {
                Debug.Log("HP < 75%, random decision is " + randomDecision);
                if(randomDecision < 75)
                {
                    // Deplacement
                    _stateMachine.walkState.nextState = _stateMachine.rightAttackState;
                    _stateMachine.Transition(_stateMachine.walkState);
                }
                else
                {
                    // Projection
                    _stateMachine.Transition(_stateMachine.dualWeaponsProjectionState);
                }
            }
        }
        else
        {
            if( randomDecision < 75)
            {
                // Attaque basique
                _stateMachine.Transition(_stateMachine.rightAttackState);
            }
            else
            {
                // Deplacement
                _stateMachine.walkState.nextState = _stateMachine.dualWeaponsProjectionState;
                _stateMachine.Transition(_stateMachine.walkState);
            }
        }
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
