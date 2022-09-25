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
    }

    private void Update()
    {
        Color32 tempColor = curColor;

        if(Input.GetKey(KeyCode.Alpha1)) curColor = cSelect.yellow;
        if(Input.GetKey(KeyCode.Alpha2)) curColor = cSelect.red;
        if(Input.GetKey(KeyCode.Alpha3)) curColor = cSelect.grey;
        if (Input.GetKey(KeyCode.Alpha4)) curColor = cSelect.purple;

        if (colorPanel != null) colorPanel.color = curColor;

        //test red for all 4, as all have a differing red value
        if (tempColor.r != curColor.r) NotifyEnemies();
    }


    private void NotifyEnemies()
    {
        foreach(GameObject ob in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            ob.GetComponent<ColorAffected>().SetSelectedColor(curColor);
        }
    }
}
