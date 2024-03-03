using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollision : MonoBehaviour
{
    public BossMain bossMain;
    public event Action<float> damage;


    public void Init(BossMain main)
    {
        bossMain = main;
        main.bossCollision = this;
    }

    private void OnTriggerEnter(Collider collision)
    {
        damage(collision.GetComponent<EquipmentMain>().equipmentStat.damage);
    }
}
