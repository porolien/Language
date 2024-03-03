using UnityEngine;

public class EquipmentAnimation : MonoBehaviour
{
    Animator animator;

    public void SetAttackToFalse()
    {
        animator.SetBool("PlayerAttacked", false);
    }

    public void SetAttackToTrue()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }

        animator.SetBool("PlayerAttacked", true);
    }
}
