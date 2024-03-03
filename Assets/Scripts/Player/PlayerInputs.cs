using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    private PlayerMain _main;

    public void Init(PlayerMain main)
    {
        _main = main;
        main.playerInput = this;
    }

    public void OnMove(InputValue _value)
    {
        _main.playerMovement.direction = _value.Get<Vector3>();

    }

    public void OnAttack()
    {

    }

    public void OnDash()
    {
        _main.playerMovement.Dash();
    }

    public void OnPotion()
    {

    }

    public void OnMenu()
    {

    }
}
