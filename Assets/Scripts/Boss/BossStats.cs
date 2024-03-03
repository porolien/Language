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
        bossMain.bossCollision.damage += TakeDamage;
    }

    private void TakeDamage(float damage)
    {
        if(bossMain.bossStats.isDead == false)
        {
            bossMain.bossStats.currentHP -= damage;
            bossMain.bossStats.percentHP = bossMain.bossStats.currentHP / bossMain.bossStats.maxHP * 100;
            Debug.Log(bossMain.bossStats.percentHP);
            if (bossMain.bossStats.currentHP <= 0)
            {
                bossMain.bossStats.isDead = true;
                Debug.Log("Aller hop le boss");
            }
        }

    }
}
