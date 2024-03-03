using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator animator;

    private string _animRunSides;
    private string _animRunForward;
    private string _animRunBackward;
    private string idleSides;
    private string idleForward;
    private string idleBackWard;
    private string attackSides;
    private string attackForward;
    private string attckBackWard;

    public void Init(PlayerMain main)
    {
        main.playerAnim = this;
    }


}
