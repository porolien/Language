using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBossState
{
    public abstract void OnEnter(BossStateMachine stateMachine);

    public abstract void OnExit();

    public abstract void Update();
}
