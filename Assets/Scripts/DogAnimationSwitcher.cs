using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimationSwitcher : MonoBehaviour
{
    [SerializeField] Vector2 lastDir = Vector2.right;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    public void UnawareOfPlayer()
    {
        anim.SetBool("isAlert", false);
    }

    public void AwareOfPlayer()
    {
        anim.SetBool("isAlert", true);
    }


    public void AttackAnimation()
    {
        anim.SetFloat("MovementX", lastDir.x);
        anim.SetFloat("MovementY", lastDir.y);
        anim.SetBool("isAttacking", true);
    }

    public void ResetAttackAnimation()
    {
        anim.SetBool("isAttacking", false);
    }


    public void HurtAnimation()
    {
        anim.SetBool("isHurt", true);
    }


    public void ResetHurtAnimation()
    {
        anim.SetBool("isHurt", false);
    }


    public void IdleAnimation()
    {
        anim.SetFloat("MovementX", lastDir.x);
        anim.SetFloat("MovementY", lastDir.y);
    }


    public void MoveAnimation(Vector2 dir, float speed)
    {
        if (dir != Vector2.zero)
        {
            lastDir = dir;

            anim.SetFloat("MovementX", lastDir.x);
            anim.SetFloat("MovementY", lastDir.y);
            anim.SetFloat("Speed", speed);
        }
    }
}
