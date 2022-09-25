using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_enemy : MonoBehaviour
{
    private VisionCone vCone;

    private void Start()
    {
        vCone = GetComponent<VisionCone>();
    }

    private void Update()
    {
        Debug.Log(vCone.CanSeePlayer);
        
    }
}
