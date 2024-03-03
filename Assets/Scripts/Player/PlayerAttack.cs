using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject sword;
    private EquipmentAnimation equipmentAnim;
    private Animator animator;


    public void Init(PlayerMain main)
    {
        main.playerAttack = this;
    }

    public void Attack()
    {
        Debug.Log("attakc");
        if (animator == null)
        {
            animator = sword.GetComponent<Animator>();
        }

        if (equipmentAnim == null)
        {
            equipmentAnim = sword.GetComponent<EquipmentAnimation>();
        }

        if (animator.GetBool("PlayerAttacked") == false)
        {
            Debug.Log("allgood");
            equipmentAnim.SetAttackToTrue();
        }
    }
}
