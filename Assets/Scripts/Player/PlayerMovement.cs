using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerMain _main;

    [Header ("Player Settings")]
    [SerializeField]
    private float speed;

    [HideInInspector]
    public Vector3 direction;

    private Vector3 oldDirection;

    [Header ("Dash Settings")]

    [SerializeField]
    public float dashSpeed;

    [SerializeField]
    private float dashDelay;

    [SerializeField]
    private float dashDuration;

    private bool isDashing;
    private bool canDash;

    public void Init(PlayerMain main)
    {
        _main = main;
        main.playerMovement = this;
    }

    public void Dash()
    {
        if(canDash)
        {
            canDash = false;
            StartCoroutine(DashCoroutine());
        }
    }

    private void Start()
    {
        canDash = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isDashing)
        {
            _main.controller.Move(direction * dashSpeed * Time.deltaTime);
        }

        else
        {
            transform.Translate(direction * speed * Time.deltaTime);

            if (oldDirection != direction)
            {
                oldDirection = direction;
                if (direction.x == 0)
                {
                    if (direction.z < 0)
                    {
                        //_main.playerAnim.SetAnimToTrue(_main.playerAnim._animRunBackward);
                        SetAnim(_main.playerAnim._animRunBackward);
                        // _main.playerAnim.animator.SetBool(_main.playerAnim._animRunBackward, true);
                    }
                    else if (direction.z > 0) 
                    {
                       // _main.playerAnim.SetAnimToTrue(_main.playerAnim._animRunForward);
                        SetAnim(_main.playerAnim._animRunForward);
                        // _main.playerAnim.animator.SetBool(_main.playerAnim._animRunForward, true);
                    }
                }
                else
                {
                    //_main.playerAnim.SetAnimToTrue(_main.playerAnim._animRunSides);
                    SetAnim(_main.playerAnim._animRunSides);
                    if (direction.x < 0)
                    {
                        GetComponent<SpriteRenderer>().flipX = true;
                        //_main.playerAnim.animator.SetBool(_main.playerAnim._animRunSides, true);
                    }
                    else
                    {
                        GetComponent<SpriteRenderer>().flipX = false;
                        //_main.playerAnim.animator.SetBool(_main.playerAnim._animRunForward, true);
                    }
                }
            }
        }
    }

    private void SetAnim(string animName)
    {
        if(_main.playerAnim.currentAnim != animName)
        {
            _main.playerAnim.SetAnimToTrue(animName);
        }
    }

    private IEnumerator DashCoroutine()
    {
        isDashing = true;
        yield return new WaitForSeconds(dashDuration);
        isDashing = false;
        yield return new WaitForSeconds(dashDelay - dashDuration);
        canDash = true;
    }
}
