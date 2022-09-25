using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //SpriteRenderer sRender;
    BoxCollider2D boxCol;
    [SerializeField] ColorAffected cAffected;

    private void Ready()
    {
        //sRender = GetComponent<SpriteRenderer>();
        boxCol = GetComponent<BoxCollider2D>();
        //cAffected = GetComponent<ColorAffected>();
    }

    //doesn't work for some reason
    private void FixedUpdate()
    {
        if (cAffected != null)
        {
            if (cAffected.Invisible) boxCol.isTrigger = true;
        }
        else Debug.Log("Still null for ducks sake");
    }
}
