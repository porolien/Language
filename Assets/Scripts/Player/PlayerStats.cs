using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float _maxHp;
    private float _currentHp;
    private float _defence;

    private EquipmentMain _equipment;
    // ajouter un équipement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeItem(EquipmentMain newEquipment)
    {
        _equipment = newEquipment;
    }
}
