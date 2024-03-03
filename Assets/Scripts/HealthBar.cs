using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public BossStats BossStats;
    public Image frontHealthImage;
    public Image backHealthImage;
    private AnimationCurve tweenCurve;
    private float tweenDuration = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        //tweenCurve = AnimationCurve.EaseInOut(0.7f, 0f, 0.84f, 0f);

        frontHealthImage.fillAmount = Mathf.InverseLerp(0, BossStats.maxHP, BossStats.currentHP);
        backHealthImage.fillAmount = Mathf.InverseLerp(0, BossStats.maxHP, BossStats.currentHP);
    }

    // Update is called once per frame
    void Update()
    {
        onHealthChanged(BossStats.currentHP);
    }
    private void onHealthChanged(float newHealth)
    {
        
        float targetFillAmount = Mathf.InverseLerp(0, BossStats.maxHP, newHealth);
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
