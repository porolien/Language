using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public BossMain boss;
    private PlayerMain player;

    [SerializeField]
    private Image frontHealthImage;
    [SerializeField]
    private Image backHealthImage;
    private float tweenDuration = 1.0f;

    public float maxHp;
    public float currentHp;

    public void Init(PlayerMain main)
    {
        main.healthBar = this;
    }

    public void Init(BossMain main)
    {
        main.healthBar = this;
    }

    public void InitHealthBar()
    {

        frontHealthImage.fillAmount = Mathf.InverseLerp(0, maxHp, currentHp);
        backHealthImage.fillAmount = Mathf.InverseLerp(0, maxHp, currentHp);
    }

    // Update is called once per frame
    void Update()
    {
        //onHealthChanged(main.bossStats.currentHP);
    }

    public void OnTakeDamage(float damage)
    {
        currentHp = currentHp - damage;
        float targetFillAmount = Mathf.InverseLerp(0, maxHp, currentHp);
        DOTween.SetTweensCapacity(1250 , 780);
        DOTween.Sequence()
            .Append(
                frontHealthImage.DOFillAmount(targetFillAmount, tweenDuration / 2f).SetEase(Ease.OutQuad)
            )
            .AppendInterval(0.5f)
            .Append(backHealthImage.DOFillAmount(targetFillAmount, tweenDuration).SetEase(Ease.OutQuad)
            );
    }

    public void OnHealthGain(float healthGain)
    {
        currentHp = currentHp + healthGain;
        if (currentHp > maxHp)
        {
            currentHp = maxHp;
        }

        frontHealthImage.fillAmount = Mathf.InverseLerp(0, maxHp, currentHp);
        backHealthImage.fillAmount = Mathf.InverseLerp(0, maxHp, currentHp);
    }
}
