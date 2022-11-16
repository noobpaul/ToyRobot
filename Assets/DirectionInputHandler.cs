using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DirectionInputHandler : MonoBehaviour
{
    public TMP_Dropdown directionInputDropdown;
    public static string directionInputValue;

    void Start()
    {
        //Fetch the DropDown component from the GameObject
        directionInputDropdown = GetComponent<TMP_Dropdown>();

        directionInputDropdown.onValueChanged.AddListener(delegate
        {
            xInputValueChanged(directionInputDropdown);
        });
    }

    void xInputValueChanged(TMP_Dropdown dropdown)
    {
        directionInputValue = dropdown.options[dropdown.value].text;
    }
}
