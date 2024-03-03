using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    public float maxHP;
    public float currentHP;
    private float damage;
    private float defense;
    public float percentHP;
    private bool isDead;
    public BossScriptable scriptable;
    private BossMain bossMain;
    public event Action<float> gainLife;

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
        percentHP = currentHP / maxHP * 100;
        isDead = false;
    }

    private void Start()
    {
        bossMain.healthBar.maxHp = maxHP;
        bossMain.healthBar.currentHp = currentHP;

        bossMain.bossCollision.damage += bossMain.healthBar.OnTakeDamage;
        bossMain.bossCollision.damage += TakeDamage;
        gainLife += bossMain.healthBar.OnHealthGain;
        gainLife += RegenLife;
    }

    private void TakeDamage(float damage)
    {
        if(bossMain.bossStats.isDead == false)
        {
            bossMain.bossStats.currentHP -= damage;
            bossMain.bossStats.percentHP = bossMain.bossStats.currentHP / bossMain.bossStats.maxHP * 100;
            if (bossMain.bossStats.currentHP <= 0)
            {
                bossMain.bossStats.isDead = true;
                Debug.Log("Aller hop le boss");
            }
        }
    }

    public void RegenLife(float lifeGain)
    {
        bossMain.bossStats.currentHP += lifeGain;
    }
}
