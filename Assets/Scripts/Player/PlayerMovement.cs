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
