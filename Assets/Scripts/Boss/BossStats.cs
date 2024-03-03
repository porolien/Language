using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    public float maxHP;
    public float currentHP;
    private float damage;
    private float defense;
    public BossScriptable scriptable;

    public void Init(BossMain main)
    {
        main.bossStats = this;
    }

    void Awake()
    {
        maxHP = scriptable.maxHP;
        currentHP = scriptable.maxHP;
        damage = scriptable.damage;
        defense = scriptable.defense;
    }
}
