using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WalkState : BaseBossState
{
    public float idealRange;
    public BaseBossState nextState;
    private BossStateMachine _stateMachine;
    private Vector3 _direction;
    private float _speed;
    private float distance;
    private float meleeRange;

    public override void OnEnter(BossStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
        _speed = 10f;
        meleeRange = 2f;
        idealRange = 10f;
    }

    public override void OnExit()
    {

    }

    public override void Update()
    {
        distance = Vector3.Distance(_stateMachine.playerMain.transform.position, _stateMachine.bossMain.transform.position);
        if (nextState == _stateMachine.rightAttackState)
        {
            idealRange = meleeRange;
            RunForward();
            if (distance > idealRange)
            {
                _stateMachine.transform.Translate(_direction * _speed * Time.deltaTime);
            }
            else
            {
                CheckForTransition();
            }
        }
        else
        {
            RunAway();
            if(distance < idealRange)
            {
                _stateMachine.transform.Translate(_direction * _speed * Time.deltaTime);
            }
            else
            {
                CheckForTransition();
            }
        }
 
    }

    public void CheckForTransition()
    {
        _stateMachine.Transition(nextState);
        // Si se déplace vers le joueur, cast l'attaque standard
        // Si s'éloigne du joueur, heal / projection / tornades
        // Une fois assez proche du joueur, cast l'attaque standard (random entre les deux )
    }

    private void RunAway()
    {
        _direction = (_stateMachine.transform.position - _stateMachine.playerMain.transform.position).normalized;
    }
    private void RunForward()
    {
        _direction = (_stateMachine.playerMain.transform.position -  _stateMachine.transform.position).normalized;
    }
}
