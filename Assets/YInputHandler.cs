using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class YInputHandler : MonoBehaviour
{
    public TMP_Dropdown yInputDropdown;
    public static int yInputValue;

    void Start()
    {
        //Fetch the DropDown component from the GameObject
        yInputDropdown = GetComponent<TMP_Dropdown>();

        yInputDropdown.onValueChanged.AddListener(delegate
        {
            xInputValueChanged(yInputDropdown);
        });
    }

    void xInputValueChanged(TMP_Dropdown dropdown)
    {
        yInputValue = dropdown.value;
    }
}
