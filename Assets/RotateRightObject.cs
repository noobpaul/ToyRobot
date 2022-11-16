using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRightObject : MonoBehaviour
{
    public void Execute()
    {
        if (MoveObject.initiateRotateRight == false)
        {
            MoveObject.initiateRotateRight = true;
        }
    }
}
