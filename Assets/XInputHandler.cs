using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XInputHandler : MonoBehaviour
{
    public TMP_Dropdown xInputDropdown;
    public static int xInputValue;

    void Start()
    {
        //Fetch the DropDown component from the GameObject
        xInputDropdown = GetComponent<TMP_Dropdown>();

        xInputDropdown.onValueChanged.AddListener(delegate
        {
            xInputValueChanged(xInputDropdown);
        });
    }

    void xInputValueChanged(TMP_Dropdown dropdown)
    {
        xInputValue = dropdown.value;
    }
}
