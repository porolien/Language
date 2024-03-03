using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator animator;

    public string _animRunSides;
    public string _animRunForward;
    public string _animRunBackward;
    public string idleSides;
    public string idleForward;
    public string idleBackWard;
    public string attackSides;
    public string attackForward;
    public string attckBackWard;

    public string currentAnim;

    public void Init(PlayerMain main)
    {
        main.playerAnim = this;
    }

    public void SetAnimToFalse(string animName)
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

        animator.SetBool(animName, false);
    }

    public void SetAnimToTrue(string animName)
    {
        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }

        animator.SetBool(animName, true);
        SetToFalse();
        currentAnim = animName;
    }

    public void SetToFalse()
    {
       // animator.SetBool(currentAnim, false);  
    }

}
