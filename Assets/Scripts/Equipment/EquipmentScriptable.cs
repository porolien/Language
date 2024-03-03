using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment", menuName = "New Assets/Equipment")]
public class EquipmentScriptable : ScriptableObject
{
    public float damage;
    public string equipmentName;
}
