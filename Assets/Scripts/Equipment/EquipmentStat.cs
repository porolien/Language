using UnityEngine;

public class EquipmentStat : MonoBehaviour
{
    private EquipmentScriptable equipmentBase;

    public float damage;

    public string equipmentName;

    void Awake()
    {
        damage = equipmentBase.damage;
        equipmentName = equipmentBase.equipmentName;
    }
}
