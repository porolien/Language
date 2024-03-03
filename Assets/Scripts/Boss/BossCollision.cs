using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollision : MonoBehaviour
{
    public BossMain bossMain;


    public void Init(BossMain main)
    {
        bossMain = main;
    }

    private void OnTriggerEnter(Collider collision)
    {
        bossMain.bossStats.currentHP -= collision.GetComponent<EquipmentMain>().equipmentStat.damage;
    }
}
