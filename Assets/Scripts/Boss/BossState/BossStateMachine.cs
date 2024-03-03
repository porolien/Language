using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class BossStateMachine : MonoBehaviour
{
    public BossMain bossMain;
    public BaseBossState currentState;
    public IdleState idleState;
    public WalkState walkState;
    public RightAttackState rightAttackState;
    public LeftAttackState leftAttackState; 
    public BasicHealState basicHealState;
    public UpgradedHealState upgradedHealState;
    public TornadoState tornadoState;
    public DualWeaponsProjectionState dualWeaponsProjectionState;

    public void Init(BossMain main)
    {
        bossMain = main;
        main.bossStateMachine = this;
    }

    // Start is called before the first frame update
    void Awake()
    {
        idleState = new IdleState();
        walkState = new WalkState();
        rightAttackState = new RightAttackState();
        leftAttackState = new LeftAttackState();
        basicHealState = new BasicHealState();
        upgradedHealState = new UpgradedHealState();
        tornadoState = new TornadoState();
        dualWeaponsProjectionState = new DualWeaponsProjectionState();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState != null) currentState.Update();
    }

    public void Transition(BaseBossState newState)
    {
        if (currentState != null)
        {
            currentState.OnExit();
        }
        currentState = newState;
        currentState.OnEnter(this);
    }
}
