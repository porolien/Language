using System;
using UnityEngine;

public class EquipmentStat : MonoBehaviour
{
    [SerializeField]
    private EquipmentScriptable equipmentBase;

    public float damage;

    public string equipmentName;

    void Awake()
    {
        damage = equipmentBase.damage;
        equipmentName = equipmentBase.equipmentName;
    }

    public void Init(EquipmentMain equipmentMain)
    {
        equipmentMain.equipmentStat = this;
    }

}
