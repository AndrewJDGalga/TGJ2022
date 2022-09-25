using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorInterface : MonoBehaviour
{
    [SerializeField] Vector2 lastDir = Vector2.right;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void AttackAnimation()
    {
        anim.SetFloat("DirY", lastDir.x);
        anim.SetFloat("DirX", lastDir.y);
        anim.SetBool("ATK", true);
    }

    public void ResetAttackAnimation()
    {
        anim.SetBool("ATK", false);
    }


    public void HurtAnimation()
    {
        anim.SetBool("HURT", true);
    }


    public void ResetHurtAnimation()
    {
        anim.SetBool("HURT", false);
    }


    public void IdleAnimation()
    {
        anim.SetFloat("DirX", lastDir.x);
        anim.SetFloat("DirY", lastDir.y);
    }


    public void MoveAnimation(Vector2 dir, float speed)
    {
        if (dir != Vector2.zero)
        {
            lastDir = dir;

            anim.SetFloat("DirX", lastDir.x);
            anim.SetFloat("DirY", lastDir.y);
            anim.SetFloat("Speed", speed);
        }
    }
}
