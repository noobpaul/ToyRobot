using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public void Execute()
    {
        if (MoveObject.initiatePlace == false)
        {
            MoveObject.initiatePlace = true;
        }
    }
}
