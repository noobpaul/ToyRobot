using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateMove : MonoBehaviour
{
    public void Execute()
    {
        if (MoveObject.initiateMove == false)
        {
            MoveObject.initiateMove = true;
        }
    }
}
