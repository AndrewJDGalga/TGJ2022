using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorViewUI : MonoBehaviour
{
    [SerializeField] Image colorPanel;
    ColorSelection cSelect = new ColorSelection();
    private Color32 curColor;

    private void Awake()
    {
        curColor = cSelect.yellow;

        if (colorPanel != null) colorPanel.color = curColor;
    }


}
