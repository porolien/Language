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

    // Start is called before the first frame update
    void Awake()
    {
        maxHP = scriptable.maxHP;
        currentHP = scriptable.maxHP;
        damage = scriptable.damage;
        defense = scriptable.defense;
    }
}
