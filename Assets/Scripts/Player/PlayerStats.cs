using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private float _maxHp;
    private float _currentHp;

    private float _defence;

    private EquipmentMain _equipment;

    public event Action<float> takeDamage;

    public event Action<float> regenPlayer;

    private PlayerMain _main;
    // ajouter un équipement

    public void Init(PlayerMain main)
    {
        _main = main;
        _main.playerStats = this;
    }

    public void ChangeItem(EquipmentMain newEquipment)
    {
        _equipment = newEquipment;
    }

    private void TakeDamage(float damage)
    {
        _currentHp = _currentHp - damage;
    }

    public void Regen(float lifeGain)
    {
        _currentHp = _currentHp + lifeGain;
        if(_currentHp > _maxHp)
        {
            _currentHp = _maxHp;
        }
    }

    private void Start()
    {
        _currentHp = _maxHp;

        takeDamage += TakeDamage;
        takeDamage += _main.healthBar.OnTakeDamage;
        regenPlayer += _main.healthBar.OnHealthGain;
        regenPlayer += Regen;

        _main.healthBar.maxHp = _maxHp;
        _main.healthBar.currentHp = _currentHp;
        _main.healthBar.InitHealthBar();
    }

    public void CallDamage(float damage)
    {
        takeDamage(damage);
    }

    public void CallRegen(float lifeGain)
    {
        regenPlayer(lifeGain);
    }
}
