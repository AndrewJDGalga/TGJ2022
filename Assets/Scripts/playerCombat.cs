using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack() 
    { 
        //detect enemies in range
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage enemies
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log(this.name + " We hit "+ enemy.name);
        }
    }

    void OnDrawGizmosSelected() 
    {
    if (attackPoint == null)
        return;
    Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}


