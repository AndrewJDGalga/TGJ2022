using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HP_UI : MonoBehaviour
{
    [SerializeField] int healthValue;
    [SerializeField] string HPSignifier = "HP: ";
    TextMeshProUGUI txtComponent;

    private void Awake()
    {
        txtComponent = GetComponent<TextMeshProUGUI>();
        txtComponent.text = HPSignifier + healthValue;
    }

    public void SetHealthUI(int newHealth)
    {
        txtComponent.text = HPSignifier + healthValue;
    }
}
