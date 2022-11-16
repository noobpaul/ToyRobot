using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeftObject : MonoBehaviour
{
    public void Execute()
    {
        if (MoveObject.initiateRotateLeft == false)
        {
            MoveObject.initiateRotateLeft = true;
        }
    }
}
