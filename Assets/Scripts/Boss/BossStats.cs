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
    private BossMain bossMain;

    public void Init(BossMain main)
    {
        main.bossStats = this;
        bossMain = main;
    }

    void Awake()
    {
        maxHP = scriptable.maxHP;
        currentHP = scriptable.maxHP;
        damage = scriptable.damage;
        defense = scriptable.defense;
    }

    private void Start()
    {
        bossMain.bossCollision.damage += TakeDamage;
    }

    private void TakeDamage(float damage)
    {
        bossMain.bossStats.currentHP -= damage;
        if(bossMain.bossStats.currentHP < 0)
        {
            Debug.Log("Aller hop le boss");
        }
    }
}
