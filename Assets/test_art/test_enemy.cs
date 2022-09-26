using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class test_enemy : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed = 2;
    private VisionCone vCone;

    private void Start()
    {
        vCone = GetComponent<VisionCone>();
    }

    private void Update()
    {
        if (vCone.CanSeePlayer)
        {
            Vector2 direction = (player.position - transform.position).normalized;

            transform.Translate(direction.x * Time.deltaTime * moveSpeed, direction.y * Time.deltaTime * moveSpeed, 0);
        }
    }
}
