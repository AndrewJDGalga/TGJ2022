using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


//should be a static class, but can't seem to setup as such due to limitations on Color32

public class ColorSelection : MonoBehaviour
{
    public readonly Color32 yellow = new Color32(192, 156, 0, 255);
    public readonly Color32 red = new Color32(197, 15, 31, 255);
    public readonly Color32 purple = new Color32(136, 23, 152, 255);
    public readonly Color32 grey = new Color32(242, 242, 242, 255);
    public readonly Color32 playerGreen = new Color32(22, 198, 12, 255);

    [SerializeField] int selectColor; //0-3, cannot set to a default value because Unity


    public Color32 GetColor()
    {
        Color32 selectedColor = yellow;

        if(selectColor < 5 && selectColor > 0) {
            switch (selectColor)
            {
                case 0:
                    selectedColor = red;
                    break;
                case 1:
                    selectedColor = purple;
                    break;
                case 2:
                    selectedColor = grey;
                    break;
            }
        }
        
        return selectedColor;
    }
}
