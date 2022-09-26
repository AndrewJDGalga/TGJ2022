using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfind : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirect;
    private VisionCone vCone;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
        vCone = GetComponent<VisionCone>();

    }

    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        //Debug.Log(vCone.CanSeePlayer);
        if(vCone.CanSeePlayer == true)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
            rb.rotation = angle;
            moveDirect = direction;
        }
    }

    private void FixedUpdate()
    {
        if(vCone.CanSeePlayer == true)
        {
            rb.velocity = new Vector2(moveDirect.x, moveDirect.y) * moveSpeed;
            rb.freezeRotation = false;
        }
        else{
            rb.velocity = Vector3.zero;
            rb.freezeRotation = true;
        }
    }


}
