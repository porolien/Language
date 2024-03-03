using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Boss", menuName = "New Assets/Boss")]
public class BossScriptable : ScriptableObject
{

    public float maxHP;
    public float damage;
    public float defense;

}
