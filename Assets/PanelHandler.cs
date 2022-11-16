using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour
{
    public GameObject Panel;

    void Start() {
        Panel.SetActive(false);
    }
}
