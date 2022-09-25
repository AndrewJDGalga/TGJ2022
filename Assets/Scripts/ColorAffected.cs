using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAffected : MonoBehaviour
{
    private ColorSelection cSelect;
    private SpriteRenderer sRender;
    private Color32 ownColor;
    private Color32 globalColor;

    private void Awake()
    {
        cSelect = GetComponent<ColorSelection>();
        sRender = GetComponent<SpriteRenderer>();
        ownColor = cSelect.GetColor();
        sRender.color = ownColor;

        if(ownColor.r != cSelect.yellow.r) sRender.enabled = false;
    }

    public void SetSelectedColor(Color32 newColor)
    {
        globalColor = newColor;
        CheckColor();
    }

    private void CheckColor()
    {
        //currently only checks red value
        if (ownColor.r == globalColor.r)
        {
            sRender.enabled = true;
        }
        else
        {
            sRender.enabled = false;
        }
    }
}
