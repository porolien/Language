using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public BossMain main;
    [SerializeField]
    private Image frontHealthImage;
    [SerializeField]
    private Image backHealthImage;
    private float tweenDuration = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        //tweenCurve = AnimationCurve.EaseInOut(0.7f, 0f, 0.84f, 0f);

        frontHealthImage.fillAmount = Mathf.InverseLerp(0, main.bossStats.maxHP, main.bossStats.currentHP);
        backHealthImage.fillAmount = Mathf.InverseLerp(0, main.bossStats.maxHP, main.bossStats.currentHP);
    }

    // Update is called once per frame
    void Update()
    {
        onHealthChanged(main.bossStats.currentHP);
    }
    private void onHealthChanged(float newHealth)
    {
        
        float targetFillAmount = Mathf.InverseLerp(0, main.bossStats.maxHP, newHealth);
        DOTween.SetTweensCapacity(1250 , 780);
        DOTween.Sequence()
            .Append(
                frontHealthImage.DOFillAmount(targetFillAmount, tweenDuration / 2f).SetEase(Ease.OutQuad)
            )
            .AppendInterval(0.5f)
            .Append(backHealthImage.DOFillAmount(targetFillAmount, tweenDuration).SetEase(Ease.OutQuad)
            );
        //frontHealthImage.DOFillAmount(targetFillAmount, tweenDuration);
            //.SetEase(tweenCurve);
    }
}
