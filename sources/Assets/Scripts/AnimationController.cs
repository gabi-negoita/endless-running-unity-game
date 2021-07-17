/**
 * Controll the animation events
 */
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartJump()
    {
        Debug.Log("START JUMP");
        animator.SetBool("isJumping", true);
    }

    public void EndJump()
    {
        Debug.Log("END JUMP");
        animator.SetBool("isJumping", false);
    }

    public void StartFall()
    {
        Debug.Log("START FALL");
        animator.SetBool("isFalling", true);
    }

    public void EndFall()
    {
        Debug.Log("END FALL");
        animator.SetBool("isFalling", false);

        // Game over - to be implemented
    }
}
