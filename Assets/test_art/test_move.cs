using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_move : MonoBehaviour
{
    const float MOVESPEED = 20f;

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        this.transform.Translate(direction * MOVESPEED * Time.deltaTime);
    }
}
