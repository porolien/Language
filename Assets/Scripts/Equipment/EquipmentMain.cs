using UnityEngine;

public class EquipmentMain : MonoBehaviour
{
    public EquipmentStat equipmentStat;

    void Awake()
    {
        SendMessage("Init", this);
    }
}
