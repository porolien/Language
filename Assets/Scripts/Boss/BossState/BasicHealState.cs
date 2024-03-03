using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicHealState : BaseBossState
{
    private BossStateMachine _stateMachine;
    public BaseBossState nextState;
    private bool isHealing = false;
    private float pauseDuration = 1.0f;
    private float currentPauseTime = 0.0f;

    public override void OnEnter(BossStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
        // Commence à se heal
        //Se soigne de ?? % de ses HP max

    }

    public override void OnExit()
    {
        // Mets l'attaque en CD pour 15s
    }

    public override void Update()
    {
        BasicHeal();

        if(isHealing)
        {
            currentPauseTime -= Time.deltaTime;
            if (currentPauseTime <= 0.0f)
            {
                isHealing = false;
            }
        }
        CheckForTransition();
    }

    private void BasicHeal()
    {
        _stateMachine.bossMain.bossStats.RegenLife(_stateMachine.bossMain.bossStats.currentHP * 0.1f);

        isHealing = true;
        currentPauseTime = pauseDuration;
    }

    private void CheckForTransition()
    {
        _stateMachine.walkState.idealRange = 10f;
        _stateMachine.walkState.nextState = _stateMachine.idleState;
        _stateMachine.Transition(_stateMachine.walkState);
    }
}
